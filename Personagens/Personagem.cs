using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens
{
	internal class Personagem
	{
		public string Nome { get; set; }
		public Raca Raca { get; set; }
		public Classe Classe { get; set; }
		public Atributos Atributos { get; set; }
		// public List<Habilidade> Habilidades { get; set; } // TODO: Estrutura de habilidades
		// public Arma Arma { get; set; } // TODO: Estrutura de Armas
		// public Armadura Armadura { get; set; } // TODO: Estrutura de Armaduras
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
		}
	}
}