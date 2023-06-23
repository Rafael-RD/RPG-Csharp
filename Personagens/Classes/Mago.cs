using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal class Mago : Classe
	{
		public Mago() : base()
		{
			Id = 2;
			Nome = "Mago";
			Atributos.Forca = 1;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 4;
			Atributos.Resistencia = 2;
			Atributos.Saude = 2;
			Atributos.PtsHabili = 20;
			Dinheiro = 20;
		}
	}
}
