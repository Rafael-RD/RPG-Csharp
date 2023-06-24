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
			Atributos.Forca = 2;
			Atributos.Destreza = 5;
			Atributos.Inteligencia = 3;
			Atributos.Resistencia = 2;
			Atributos.Saude = 30;
			Atributos.PtsHabili = 3;
			DinheiroMin = 0;
			DinheiroMax = 5;
		}
	}
}
