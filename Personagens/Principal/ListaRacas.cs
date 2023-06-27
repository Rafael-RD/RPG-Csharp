using projeto1_RPG.Personagens.Racas.Global;
using projeto1_RPG.Personagens.Racas.Oponente.Bestiais;
using projeto1_RPG.Personagens.Racas.Oponente.Humanoides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal class ListaRacas
	{
		private static List<Raca> RacasGlobal { get; set; }
		private static List<Raca> RacasOponente { get; set; }

		private static readonly Random _rnd = new Random();

		public ListaRacas() { }

		public static List<Raca> GetRacasGlobal()
		{
			if (RacasGlobal == null)
			{
				RacasGlobal = new List<Raca>
				{
					new Anao(),
					new Elfo(),
					new Humano()
				};
			}
			return RacasGlobal;
		}

		public static List<Raca> GetRacasOponente()
		{
			if (RacasOponente == null)
			{
				RacasOponente = new List<Raca>
				{
					new Anao(),
					new Elfo(),
					new Humano(),
					new Esqueleto(),
					new Gnoll(),
					new Goblin(),
					new Homem_Rato(),
					new Kobold(),
					new Orc(),
					new Warg(),
				};
			}
			return RacasOponente;
		}

		public static Raca RandomOponente()
		{
			return GetRacasOponente()[_rnd.Next(GetRacasOponente().Count)];
		}
	}
}
