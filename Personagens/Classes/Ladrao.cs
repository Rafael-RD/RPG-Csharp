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
	internal class Ladrao : Classe
	{
		public Ladrao() : base()
		{
			Id = 3;
			Nome = "Ladrão";
            Atributos.SetAtributos(2, 5, 2, 2, 50, 0);
            Incrementos.SetAtributos(1, 2, 1, 1, 3, 2);
            Dinheiro = 100;
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 3));
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 4));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 1));
        }
	}
}
