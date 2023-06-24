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
			Atributos.Forca = 5;
			Atributos.Destreza = 5;
			Atributos.Inteligencia = 5;
			Atributos.Resistencia = 5;
			Atributos.Saude = 60;
			Atributos.PtsHabili = 5;
			DinheiroMin = 0;
			DinheiroMax = 5;
		}
	}
}
