using projeto1_RPG.Habilidades;
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
			Atributos.SetAtributos(3, 2, 3, 2, 12, 1);
			Incrementos.SetAtributos(1, 1, 2, 2, 4, 2);
			Dinheiro = 30;
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 2));
            KitInicial.Add(ListaArmas.GetArmas().Find(a => a.Id == 8));
            KitInicial.Add(ListaArmaduras.GetArmaduras().Find(a => a.Id == 2));
            HabilidadesIniciais.Add(ListaHabilidades.HabilidadesOfensivas.Find(a => a.Id == 5));
        }

		public override string GetDescPtsHabili()
		{
			return "Fé";
		}
	}
}
