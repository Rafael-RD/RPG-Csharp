using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Homem_Rato : Raca
	{
		public Homem_Rato() : base()
		{
			Id = 15;
			Nome = "Homem-Rato";
			Atributos.SetAtributos(2, 5, 3, 2, 7, 3);
			DinheiroMin = 1;
			DinheiroMax = 10;
		}
	}
}
