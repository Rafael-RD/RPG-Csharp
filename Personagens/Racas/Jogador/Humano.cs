using projeto1_RPG.Personagens.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Jogador
{
	internal class Humano : Raca
	{
		public Humano() : base()
		{
			Id = 1;
			Nome = "Humano";
			Atributos.Forca = 2;
			Atributos.Destreza = 2;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 2;
			Atributos.Saude = 2;
		}
	}
}