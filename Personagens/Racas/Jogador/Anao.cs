using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Jogador
{
	internal class Anao : Raca
	{
		public Anao() : base()
		{
			Id = 3;
			Nome = "Anão";
			Atributos.Forca = 3;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 2;
			Atributos.Saude = 3;
			DinheiroMin = 5;
			DinheiroMax = 15;
		}
	}
}