using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Classes
{
	internal class Ladrao : Classe
	{
		public Ladrao() : base()
		{
			Id = 3;
			Nome = "Ladrão";
			Atributos.Forca = 1;
			Atributos.Destreza = 4;
			Atributos.Inteligencia = 2;
			Atributos.Resistencia = 2;
			Atributos.Saude = 1;
			Dinheiro = 40;
		}
	}
}