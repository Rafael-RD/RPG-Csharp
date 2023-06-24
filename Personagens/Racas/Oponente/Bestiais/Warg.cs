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
			Atributos.Forca = 5;
			Atributos.Destreza = 3;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 4;
			Atributos.Saude = 50;
			Atributos.PtsHabili = 2;
			DinheiroMin = 0;
			DinheiroMax = 0;
		}
	}
}
