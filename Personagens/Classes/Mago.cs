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
			Atributos.SetAtributos(1, 2, 6, 1, 40, 1);
			Incrementos.SetAtributos(1, 1, 2, 1, 2, 3);
			Dinheiro = 15;
		}
	}
}
