using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Global
{
	internal class Humano : Raca
	{
		public Humano() : base()
		{
			Id = 1;
			Nome = "Humano";
			Atributos.SetAtributos(5, 5, 5, 5, 60, 5);
			DinheiroMin = 1;
			DinheiroMax = 20;
		}
	}
}
