using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Itens.Armas;
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
			Incrementos.SetAtributos(2, 1, 1, 1, 5, 1);
			KitInicial.Add(new Arma("Espada", "Espada de Batalha", 10, "Neutro", "Cortante", 100, 150));
			KitInicial.Add(new Armadura("Armadura de Metal", "Armadura feita com metal", 10, 100));
			Dinheiro = 50;
		}
	}
}
