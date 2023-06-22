using projeto1_RPG.Personagens.Racas.Jogador;
using projeto1_RPG.Personagens.Racas.Oponente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas
{
	internal class ListaRacas
	{
		private static List<Raca> RacasJogador { get; set; }
		private static List<Raca> RacasOponente { get; set; }
		public static List<Raca> GetRacasJogador()
		{
			if (RacasJogador == null)
			{
				RacasJogador = new List<Raca>
				{
					new Humano(),
					new Elfo(),
					new Anao()
				};
			}
			return RacasJogador;
		}
		public static List<Raca> GetRacasOponente()
		{
			if (RacasOponente == null)
			{
				RacasOponente = new List<Raca>
				{
					new Humano(),
					new Elfo(),
					new Anao(),
					new Esqueleto(),
					new Goblin(),
					new Orc(),
				};
			}
			return RacasOponente;
		}
	}
}