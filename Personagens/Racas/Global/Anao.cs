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
			Atributos.Forca = 6;
			Atributos.Destreza = 3;
			Atributos.Inteligencia = 3;
			Atributos.Resistencia = 6;
			Atributos.Saude = 90;
			Atributos.PtsHabili = 4;
			DinheiroMin = 5;
			DinheiroMax = 15;
		}
	}
}
