using projeto1_RPG.Personagens.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal class ListaClasses
	{
		private static List<Classe> Classes { get; set; }

		public ListaClasses() { }

		public static List<Classe> GetClasses()
		{
			if (Classes == null)
			{
				Classes = new List<Classe>
				{
					new Clerigo(),
					new Guerreiro(),
					new Ladrao(),
					new Mago()
				};
			}
			return Classes;
		}
		public static Classe Random()
		{
			return GetClasses()[new Random().Next(GetClasses().Count)];
		}
	}
}
