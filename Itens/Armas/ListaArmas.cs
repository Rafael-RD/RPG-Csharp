using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Armas
{
	internal class ListaArmas
	{
		private static List<Arma> Armas { get; set; }
		public static List<Arma> GetArmas()
		{
			if (Armas == null)
			{
				Armas = new List<Arma>
				{
				};
			}
			return Armas;
		}
	}
}
