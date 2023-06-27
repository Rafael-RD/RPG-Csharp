using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Itens.Armas;
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
			Atributos.SetAtributos(3, 2, 3, 2, 60, 0);
			Incrementos.SetAtributos(0, 0, 0, 0, 0, 0);
			Dinheiro = 10;
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 2));
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 8));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 2));
        }
	}
}
