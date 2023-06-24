using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Gnoll : Raca
	{
		public Gnoll() : base()
		{
			Id = 17;
			Nome = "Gnoll";
			Atributos.SetAtributos(4, 3, 2, 4, 40, 2);
			DinheiroMin = 5;
			DinheiroMax = 15;
		}
	}
}
