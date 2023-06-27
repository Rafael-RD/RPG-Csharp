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
	internal class Mago : Classe
	{
		public Mago() : base()
		{
			Id = 2;
			Nome = "Mago";
			Atributos.SetAtributos(1, 2, 6, 1, 40, 0);
			Incrementos.SetAtributos(0, 0, 0, 0, 0, 0);
			Dinheiro = 20;
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 5));
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 6));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 3));
        }
	}
}
