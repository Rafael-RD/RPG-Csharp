using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente
{
	internal class Esqueleto : Raca
	{
		public Esqueleto() : base()
		{
			Id = 11;
			Nome = "Esqueleto";
			Atributos.Forca = 2;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 0;
			Atributos.Resistencia = 1;
			Atributos.Saude = 1;
			DinheiroMin = 0;
			DinheiroMax = 5;
		}
	}
}