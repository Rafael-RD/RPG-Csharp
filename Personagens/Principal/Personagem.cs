using projeto1_RPG.Principal;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Itens;
using projeto1_RPG.Itens.Armas;
using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Efeitos;
using projeto1_RPG.Combate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal abstract class Personagem
	{
		public string Nome { get; set; }
		public Raca Raca { get; set; }
		public Classe Classe { get; set; }
		public Nivel Nivel { get; set; }
		public Atributos Atributos { get; set; }
		public int SaudeAtual { get; set; }
		public int PtsHabiliAtual { get; set; }
		public List<Item> Inventario { get; private set; }
		public Arma Arma { get; set; }
		public Armadura Armadura { get; set; }
		public int Dinheiro { get; set; }
		public List<Efeito> Efeitos { get; private set; }

		public Personagem(Raca raca, Classe classe, int nivel = 1)
		{
			Nome = string.Empty;
			Raca = raca;
			Classe = classe;
			Nivel = new Nivel(nivel);
			Atributos = new Atributos();
			Atributos.SomarAtributos(Raca.Atributos);
			Atributos.SomarAtributos(Classe.Atributos);
			SaudeAtual = Atributos.Saude;
			PtsHabiliAtual = Atributos.PtsHabili;
			Inventario = new List<Item>();
			Arma = null;
			Armadura = null;
			Dinheiro = Raca.GetDinheiro() + (Classe.Dinheiro * (nivel / 2));
			Efeitos = new List<Efeito>();
		}

		public void ReceberRecompensa(Oponente oponente)
		{
			Nivel.ExpAtual += oponente.Nivel.ExpAtual;
			Nivel.AvancarNivel();
			Dinheiro += oponente.Dinheiro;
		}

		public void AvancarNivel()
		{
			Nivel.AvancarNivel();
			Atributos.SomarAtributos(Classe.Incrementos);
			SaudeAtual = Atributos.Saude;
			PtsHabiliAtual = Atributos.PtsHabili;
		}

		public enum AcaoTurno
		{
			Nenhum,
			Atacar,
			Defender,
			Habilidades,
			Inventario,
			Fugir
		}

		public abstract AcaoTurno EscolherAcao();
		public abstract Habilidade SelecionarHabilidade();
		public abstract Personagem SelecionarAlvo(List<Personagem> fila, bool aliado);
		public abstract Item SelecionarItem();

		public void IniciouTurno()
		{
			foreach (Efeito e in this.Efeitos) { if (--e.Turnos == 0) this.Efeitos.Remove(e); }
		}

		public void ReceberAtaque(Personagem origem, Ataque ataque)
		{
			int danoIni = ataque.CalcDano();
			int armadura = (this.Armadura == null) ? 0 : this.Armadura.CalculaReducao(ataque);
			int dano = danoIni - armadura;

			// Efeitos de redução ou aumento de dano
			int efeitos = dano;
			foreach (Efeito e in this.Efeitos)
			{
				if (e is IGatilhoDanoAposArmadura) dano = ((IGatilhoDanoAposArmadura)e).DanoAposArmadura(dano);
			}
			efeitos = dano - efeitos;

			string info = ((armadura != 0) ? $" - {Math.Abs(armadura)} (armadura)" : String.Empty) +
							((efeitos != 0) ? $" {(efeitos < 0 ? "-" : "+")} {Math.Abs(efeitos)} (efeitos)" : String.Empty);
			if (info != String.Empty) info = $"[{danoIni} (ataque) {info}]";

			Console.WriteLine($"{this.Nome} recebe {dano} pontos de dano. {info}");
			this.SaudeAtual -= dano;
		}

		public void Atacar(Personagem alvo)
		{
			if (this.Arma == null) alvo.ReceberAtaque(this, new Ataque(null, 1, this.Atributos.Forca));
			else alvo.ReceberAtaque(this, this.Arma.Ataque);
		}

		public void Defender()
		{
			this.Efeitos.Add(new EfeitoDefesa());
		}
	}
}