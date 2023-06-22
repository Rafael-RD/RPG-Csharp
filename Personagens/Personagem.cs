using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Itens.Armas;
using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Efeitos;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens
{
	internal abstract class Personagem
	{
		public string Nome { get; set; }
		public Raca Raca { get; set; }
		public Classe Classe { get; set; }
		public Atributos Atributos { get; set; }
		public Arma? Arma { get; set; }
		public Armadura? Armadura { get; set; }
		public List<Habilidade> Habilidades { get; set; }
		public List<Efeito> Efeitos { get; set; }
		public int SaudeAtual { get; set; }
		public int Nivel { get; set; }
		public int Exp { get; set; }

		public Personagem(Raca raca, Classe classe)
		{
			Nome = String.Empty;
			Raca = raca;
			Classe = classe;
			Arma = null;
			Armadura = null;
			Atributos = new Atributos();
			Atributos.SomarAtributos(Raca.Atributos);
			Atributos.SomarAtributos(Classe.Atributos);

			Habilidades = new List<Habilidade>();
			Habilidades.AddRange(Raca.Habilidades);
			Habilidades.AddRange(Classe.Habilidades);

			Efeitos = new List<Efeito>();
		}

		public enum AcaoTurno
		{
            Nenhum,
			Atacar,
            Defender,
            Habilidades,
			Fujir
		}
		public abstract AcaoTurno EscolherAcao();
        public abstract Habilidade? SelecionarHabilidade();
		public abstract Personagem? SelecionarAlvo(List<Personagem> fila, Habilidade? habilidade = null);

		public void IniciouTurno()
		{
			foreach (Efeito e in this.Efeitos) { if (--e.Turnos == 0) this.Efeitos.Remove(e); }
		}

		private void ReceberAtaque(Personagem origem, Ataque ataque)
		{
			int dano = ataque.CalcDano();
			foreach (Efeito e in this.Efeitos)
			{
				if (e is IEfeitoAposCalcularDano) dano = ((IEfeitoAposCalcularDano)e).AposCalcularDano(dano);
			}

			this.SaudeAtual -= dano;
		}

		public void Atacar(Personagem alvo)
		{
			if (this.Arma != null) alvo.ReceberAtaque(this, this.Arma.Ataque);
		}

		public void Defender()
		{
			this.Efeitos.Add(new EfeitoDefesa());
		}

		public void Habilidade(Habilidade habilidade, Personagem alvo)
		{
			alvo.ReceberAtaque(this, habilidade.Ataque);
		}
	}
}