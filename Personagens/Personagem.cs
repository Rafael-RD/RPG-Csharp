using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Efeitos;
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
		public List<Habilidade> Habilidades { get; set; } // TODO: Estrutura de Habilidades
		// public Arma Arma { get; set; } // TODO: Estrutura de Armas
		// public Armadura Armadura { get; set; } // TODO: Estrutura de Armaduras
		public List<Efeito> Efeitos { get; set; }
		public int SaudeAtual { get; set; }
		public int Nivel { get; set; }
		public int Exp { get; set; }
		public Personagem(Raca raca, Classe classe)
		{
			Nome = String.Empty;
			Raca = raca;
			Classe = classe;
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
		public abstract Personagem? SelecionarAlvo(List<Personagem> fila);

		public void IniciouTurno()
		{
			foreach (Efeito e in Efeitos) { if (--e.Turnos == 0) Efeitos.Remove(e); }
		}

		public void Atacar(Personagem alvo)
		{
			// TODO: Atacar alvo
		}

		public void Defender()
		{
			Efeitos.Add(new EfeitoDefesa());
		}

		public void Habilidade(Habilidade habilidade, Personagem alvo)
		{
			// TODO: Usar habilidade
		}
	}
}