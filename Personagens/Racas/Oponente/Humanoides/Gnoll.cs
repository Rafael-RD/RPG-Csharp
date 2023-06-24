using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Gnoll : Raca
	{
		public Gnoll() : base()
		{
			Id = 17;
			Nome = "Gnoll";
			Atributos.Forca = 4;
			Atributos.Destreza = 3;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 4;
			Atributos.Saude = 2;
			Atributos.PtsHabili = 40;
			Atributos.PtsHabili = 2;
			DinheiroMin = 5;
			DinheiroMax = 15;
		}
	}
}
