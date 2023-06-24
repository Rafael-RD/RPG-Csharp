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
			Atributos.Forca = 3;
			Atributos.Destreza = 6;
			Atributos.Inteligencia = 6;
			Atributos.Resistencia = 3;
			Atributos.Saude = 70;
			Atributos.PtsHabili = 7;
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
