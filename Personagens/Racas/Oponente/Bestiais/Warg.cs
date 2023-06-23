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
			Atributos.Forca = 3;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 0;
			Atributos.Resistencia = 2;
			Atributos.Saude = 3;
			DinheiroMin = 0;
			DinheiroMax = 0;
		}
	}
}
