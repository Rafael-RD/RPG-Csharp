using projeto1_RPG.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal abstract class Classe
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public Atributos Atributos { get; set; }
		public Atributos Incrementos { get; set; }
		public List<Habilidade> Habilidades { get; set; }
		public int Dinheiro { get; set; }

		public Classe()
		{
			Nome = string.Empty;
			Atributos = new Atributos();
			Incrementos = new Atributos();
			Habilidades = new List<Habilidade>();
		}
	}
}
