using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Orc : Raca
	{
		public Orc() : base()
		{
			Id = 13;
			Nome = "Orc";
			Atributos.SetAtributos(5, 2, 1, 5, 50, 2);
			DinheiroMin = 5;
			DinheiroMax = 10;
		}
	}
}
