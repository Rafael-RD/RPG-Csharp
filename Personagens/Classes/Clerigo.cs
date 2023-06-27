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
			Atributos.SetAtributos(3, 2, 3, 2, 12, 1);
			Incrementos.SetAtributos(1, 1, 2, 2, 4, 2);
			Dinheiro = 30;
		}

		public override string GetDescPtsHabili()
		{
			return "Fé";
		}
	}
}
