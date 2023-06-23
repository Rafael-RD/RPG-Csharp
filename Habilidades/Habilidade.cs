using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
	internal class Habilidade
	{
		public string Nome { get; set; }
		public int Custo { get; set; }
		public Ataque Ataque { get; set; }

		public Habilidade(string nome, int custo, Ataque ataque)
		{
			Nome = nome;
			Custo = custo;
			Ataque = ataque;
		}
	}
}
