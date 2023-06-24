using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Orc : Raca
	{
		public Orc() : base()
		{
			Id = 13;
			Nome = "Orc";
			Atributos.Forca = 5;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 5;
			Atributos.Saude = 50;
			Atributos.PtsHabili = 2;
			DinheiroMin = 5;
			DinheiroMax = 10;
		}
	}
}
