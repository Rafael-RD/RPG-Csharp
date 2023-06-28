using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Armaduras
{
	internal class ListaArmaduras
	{
		private static List<Armadura> Armaduras { get; set; }
		public static List<Armadura> GetArmaduras()
		{
			if (Armaduras == null)
			{
				Armaduras = new List<Armadura>
				{
                    new Armadura(1, "Armadura Leve", "Uma armadura leve e delicada feita de tecido", 5, 2),
                    new Armadura(2, "Armadura Média", "Uma armadura intermediária feita de couro resistente", 10, 4),
                    new Armadura(3, "Armadura Pesada", "Uma armadura resistente feita de placas metálicas", 15, 6),
                };
			}
			return Armaduras;
		}
	}
}
