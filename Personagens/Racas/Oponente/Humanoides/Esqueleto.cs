using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Esqueleto : Raca
	{
		public Esqueleto() : base()
		{
			Id = 11;
			Nome = "Esqueleto";
			Atributos.SetAtributos(3, 3, 1, 3, 8, 3);
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
