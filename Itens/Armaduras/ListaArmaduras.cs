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
                    new Armadura("Armadura de Tecido", "Armadura feita com tecido", 5, 25),
                    new Armadura("Armadura de Couro", "Armadura feita com Couro", 15, 50),
                    new Armadura("Armadura de Metal", "Armadura feita com Metal", 50, 100)
				};
			}
			return Armaduras;
		}
	}
}