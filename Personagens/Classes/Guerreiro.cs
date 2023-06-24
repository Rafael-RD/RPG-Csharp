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
			Atributos.Forca = 3;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 3;
			Atributos.Saude = 2;
			Dinheiro = 10;
			KitInicial.Add(new Arma("Espada", "Espada de Batalha", 10, "Neutro", "Cortante", 100, 150));
			KitInicial.Add(new Armadura("Armadura de Metal", "Armadura feita com metal", 10, 100));

        }
	}
}