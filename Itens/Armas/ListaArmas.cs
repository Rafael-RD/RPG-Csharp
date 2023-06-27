using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Armas
{
	internal class ListaArmas
	{
		private static List<Arma> Armas { get; set; }
		public static List<Arma> GetArmas()
		{
			if (Armas == null)
			{
				Armas = new List<Arma>
				{
					new Arma(1, "Espada Longa", "Uma espada de uma m�o", 80, Categoria.Elemento.Neutro, Categoria.Fisico.Cortante, 5, 10),
					new Arma(7, "Machado de Batalha", "Um machado imponente e de grande porte, projetado para ser empunhado com as duas m�os", 80, Categoria.Elemento.Neutro, Categoria.Fisico.Cortante, 5, 10),//machado
                    new Arma(2, "Martelo de Guerra", "Um martelo pesado de batalha", 120, Categoria.Elemento.Neutro, Categoria.Fisico.Impacto, 7, 12),
                    new Arma(3, "Arco Longo", "Um arco de grande alcance", 80, Categoria.Elemento.Neutro, Categoria.Fisico.Perfurante, 4, 8),
                    new Arma(4, "Adaga Envenenada", "Uma adaga com l�mina envenenada", 120, Categoria.Elemento.Veneno, Categoria.Fisico.Perfurante, 3, 6),
                    new Arma(5, "Cajado de Fogo", "Um cajado capaz de conjurar chamas", 130, Categoria.Elemento.Fogo, Categoria.Fisico.Impacto, 6, 11),
                    new Arma(6, "Varinha de Gelo", "Uma varinha imbuida com poderes g�lidos", 130, Categoria.Elemento.Gelo, Categoria.Fisico.Impacto, 4, 7),//add efeito
                    new Arma(8, "Ma�a Estrela", "Uma ma�a pesada com pontas afiadas em formato de estrela em sua cabe�a", 130, Categoria.Elemento.Neutro, Categoria.Fisico.Impacto, 4, 7)//ma�a estrela
					
                };
			}
			return Armas;
		}
	}
}
