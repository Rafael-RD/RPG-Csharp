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
			Atributos.SetAtributos(6, 3, 3, 6, 90, 40);
			DinheiroMin = 5;
			DinheiroMax = 15;
		}
	}
}
