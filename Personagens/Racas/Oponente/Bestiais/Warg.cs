using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Bestiais
{
	internal class Warg : Raca
	{
		public Warg() : base()
		{
			Id = 16;
			Nome = "Warg";
			Atributos.SetAtributos(5, 3, 1, 4, 10, 2);
			DinheiroMin = 0;
			DinheiroMax = 0;
		}
	}
}
