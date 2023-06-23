using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Kobold : Raca
	{
		public Kobold() : base()
		{
			Id = 14;
			Nome = "Kobold";
			Atributos.Forca = 1;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 2;
			Atributos.Saude = 2;
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
