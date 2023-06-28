using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Global
{
	internal class Anao : Raca
	{
		public Anao() : base()
		{
			Id = 3;
			Nome = "Anão";
			Atributos.SetAtributos(6, 3, 3, 6, 15, 4);
			DinheiroMin = 10;
			DinheiroMax = 100;
		}
	}
}
