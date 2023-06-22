using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal class ListaClasses
	{
		private static List<Classe> Classes { get; set; }
		public static List<Classe> GetClasses()
		{
			if (Classes == null)
			{
				Classes = new List<Classe>
				{
					new Guerreiro(),
					new Mago(),
					new Ladrao()
				};
			}
			return Classes;
		}
	}
}