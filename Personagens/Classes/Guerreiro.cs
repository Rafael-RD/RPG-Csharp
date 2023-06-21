using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal class Guerreiro : Classe
	{
		public Guerreiro() : base()
		{
			Id = 1;
			Nome = "Guerreiro";
			Atributos.Forca = 3;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 3;
			Atributos.Saude = 2;
		}
	}
}