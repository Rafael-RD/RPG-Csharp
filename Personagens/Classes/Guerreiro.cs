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
			KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 1));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 1));

        }
	}
}