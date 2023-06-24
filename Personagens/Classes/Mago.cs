using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Itens.Armas;
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
			Dinheiro = 20;
            KitInicial.Add(new Arma("Cajado", "Cajado de fogo", 10, "Fogo", "Neutro", 100, 150));
            KitInicial.Add(new Armadura("Armadura de Pano", "Armadura feita com pano", 10, 50));
        }
	}
}