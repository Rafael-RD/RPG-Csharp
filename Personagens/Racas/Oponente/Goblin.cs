using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente
{
	internal class Goblin : Raca
	{
		public Goblin() : base()
		{
			Id = 12;
			Nome = "Goblin";
			Atributos.Forca = 1;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 2;
			Atributos.Saude = 1;
		}
	}
}