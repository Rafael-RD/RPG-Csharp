using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal abstract class Classe
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public Atributos Atributos { get; set; }
		public Classe()
		{
			Nome = string.Empty;
			Atributos = new Atributos();
		}
	}
}