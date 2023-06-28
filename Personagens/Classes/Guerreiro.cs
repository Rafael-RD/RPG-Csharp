using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Itens.Armaduras;
using projeto1_RPG.Itens.Armas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto1_RPG.Habilidades;

namespace projeto1_RPG.Personagens.Classes
{
	internal class Guerreiro : Classe
	{
		public Guerreiro() : base()
		{
			Id = 1;
			Nome = "Guerreiro";
			Atributos.SetAtributos(6, 2, 1, 3, 15, 0);
			Incrementos.SetAtributos(2, 1, 1, 1, 5, 1);
            Dinheiro = 50;
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 1));
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 7));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 3));
			HabilidadesIniciais.Add(ListaHabilidades.HabilidadesOfensivas.Find(a => a.Id == 6));
        }

		public override string GetDescPtsHabili()
		{
			return "Stamina";
		}
	}
}
