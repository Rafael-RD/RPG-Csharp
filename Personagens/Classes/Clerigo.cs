using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal class Clerigo : Classe
	{
		public Clerigo() : base()
		{
			Id = 4;
			Nome = "Clérigo";
			Atributos.Forca = 2;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 3;
			Atributos.Saude = 2;
			Atributos.PtsHabili = 5;
			Dinheiro = 10;
		}
	}
}
