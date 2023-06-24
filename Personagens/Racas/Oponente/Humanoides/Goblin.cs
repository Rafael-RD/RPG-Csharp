using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Goblin : Raca
	{
		public Goblin() : base()
		{
			Id = 12;
			Nome = "Goblin";
			Atributos.SetAtributos(2, 4, 2, 2, 40, 2);
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
