using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Esqueleto : Raca
	{
		public Esqueleto() : base()
		{
			Id = 11;
			Nome = "Esqueleto";
			Atributos.Forca = 3;
			Atributos.Destreza = 3;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 3;
			Atributos.Saude = 40;
			Atributos.PtsHabili = 3;
			DinheiroMin = 0;
			DinheiroMax = 5;
		}
	}
}
