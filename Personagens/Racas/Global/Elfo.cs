using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Global
{
	internal class Elfo : Raca
	{
		public Elfo() : base()
		{
			Id = 2;
			Nome = "Elfo";
			Atributos.SetAtributos(3, 6, 6, 3, 70, 7);
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
