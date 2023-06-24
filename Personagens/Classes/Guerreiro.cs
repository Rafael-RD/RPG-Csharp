using projeto1_RPG.Personagens.Principal;
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
			Atributos.SetAtributos(6, 2, 1, 3, 70, 0);
			Incrementos.SetAtributos(2, 0, 0, 0, 0, 0);
			Dinheiro = 10;
		}
	}
}
