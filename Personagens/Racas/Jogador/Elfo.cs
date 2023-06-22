using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Jogador
{
	internal class Elfo : Raca
	{
		public Elfo() : base()
		{
			Id = 2;
			Nome = "Elfo";
			Atributos.Forca = 1;
			Atributos.Destreza = 3;
			Atributos.Inteligencia = 3;
			Atributos.Resistencia = 2;
			Atributos.Saude = 1;
		}
	}
}