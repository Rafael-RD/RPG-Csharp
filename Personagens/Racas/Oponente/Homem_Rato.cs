using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente
{
	internal class Homem_Rato : Raca
	{
		public Homem_Rato()
		{
			Id = 15;
			Nome = "Homem-Rato";
			Atributos.Forca = 1;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 2;
			Atributos.Saude = 2;
			DinheiroMin = 0;
			DinheiroMax = 5;
		}
	}
}