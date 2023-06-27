using projeto1_RPG.Principal;
using projeto1_RPG.Combates;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Itens;
using projeto1_RPG.Itens.Armas;
using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Efeitos;
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
		public int PtsSaudeAtual { get; set; }
		public int PtsHabiliAtual { get; set; }
		public List<Item> Inventario { get; private set; }
		public Arma Arma { get; set; }
		public Armadura Armadura { get; set; }
		public int Dinheiro { get; set; }
		public List<Efeito> Efeitos { get; private set; }

		public Personagem(string nome, Raca raca, Classe classe, int nivel = 1)
		{
			Nome = nome;
			Raca = raca;
			Classe = classe;
			Nivel = new Nivel(nivel);
			Atributos = new Atributos();
			Atributos.SomarAtributos(Raca.Atributos);
			Atributos.SomarAtributos(Classe.Atributos);
			if (nivel > 1)
			{
				IncrementarAtributos(nivel - 1);
			}
			PtsSaudeAtual = Atributos.PtsSaudeMax;
			PtsHabiliAtual = Atributos.PtsHabiliMax;

			Inventario = new List<Item>();
			Inventario.AddRange(Classe.KitInicial);
			SelecionarArma();
			SelecionarArmadura();

			Inventario = new List<Item>();
			Arma = null;
			Armadura = null;
			Dinheiro = Raca.GetDinheiro() + (Classe.Dinheiro * nivel) / 2;
			Efeitos = new List<Efeito>();
		}

		public void IncrementarAtributos(int qtdNiveis = 0)
		{
			do
			{
				Atributos.SomarAtributos(Classe.Incrementos);
				PtsSaudeAtual = Atributos.PtsSaudeMax;
				PtsHabiliAtual = Atributos.PtsHabiliMax;
				qtdNiveis--;
			}
			while (qtdNiveis > 0);
		}

		public void ReceberRecompensa(Oponente oponente)
		{
			if (oponente.Nivel.NivelAtual == 1)
			{
				oponente.Nivel.ExpAtual = Nivel.ExpBase;
			}
			Nivel.ExpAtual += oponente.Nivel.ExpRecompensa;
			Nivel.CalcExperiencia();
			if (Nivel.AvancouNivel)
			{
				IncrementarAtributos();
			}
			Dinheiro += oponente.Dinheiro / 2;
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

		public bool IniciouTurno()
		{
			bool iniciaTurno = true;
			for (int i = Efeitos.Count - 1; i >= 0; i--)
			{
				Efeito e = Efeitos[i];
				if (e is IGatilhoPodeIniciarTurno) iniciaTurno = iniciaTurno && ((IGatilhoPodeIniciarTurno)e).PodeIniciarTurno(this);

				if (--e.Turnos == 0) this.Efeitos.Remove(e);
			}

			return iniciaTurno;
		}

		private void SelecionarArma()
		{
			foreach (Item item in Inventario)
			{
				if (item is Arma)
				{
					this.Arma = (Arma)item;
					break;
				}
			}
		}

		private void SelecionarArmadura()
		{
			foreach (Item item in Inventario)
			{
				if (item is Armadura)
				{
					this.Armadura = (Armadura)item;
					break;
				}
			}
		}

		public void ReceberAtaque(Personagem origem, Ataque ataque)
		{
			int armadura = (this.Armadura == null) ? 0 : this.Armadura.CalculaReducao(ataque);
			int dano = ataque.CalcDano() - armadura;

			// Efeitos de redução ou aumento de dano
			foreach (Efeito e in this.Efeitos)
			{
				if (e is IGatilhoDanoAposArmadura) dano = ((IGatilhoDanoAposArmadura)e).DanoAposArmadura(this, dano);
			}

			Console.WriteLine($"{this.Nome} recebe {dano} pontos de dano.");
			this.PtsSaudeAtual -= dano;
		}

		public void Atacar(Personagem alvo)
		{
			if (this.Arma == null) alvo.ReceberAtaque(this, new Ataque(null, 1, this.Atributos.Forca));
			else this.Arma.Atacar(this, alvo);
		}

		public void Defender()
		{
			this.Efeitos.Add(new EfeitoDefesa());
		}
	}
}