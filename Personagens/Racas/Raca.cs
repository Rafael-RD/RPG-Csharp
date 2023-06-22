using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas
{
	internal abstract class Raca
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public Atributos Atributos { get; set; }
		public List<Habilidade> Habilidades { get; set; }
		public Raca()
		{
			Nome = String.Empty;
			Atributos = new Atributos();
			Habilidades = new List<Habilidade>();
		}
	}
}