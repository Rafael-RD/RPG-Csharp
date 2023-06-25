using projeto1_RPG.Personagens.Principal;
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
			Atributos.SetAtributos(2, 5, 2, 2, 50, 0);
			Incrementos.SetAtributos(1, 2, 1, 1, 3, 2);
			Dinheiro = 110;
		}
	}
}
