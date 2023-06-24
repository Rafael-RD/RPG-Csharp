using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente.Humanoides
{
	internal class Goblin : Raca
	{
		public Goblin() : base()
		{
			Id = 12;
			Nome = "Goblin";
			Atributos.Forca = 2;
			Atributos.Destreza = 4;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 2;
			Atributos.Saude = 40;
			Atributos.PtsHabili = 2;
			DinheiroMin = 0;
			DinheiroMax = 10;
		}
	}
}
