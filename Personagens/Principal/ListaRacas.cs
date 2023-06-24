﻿using projeto1_RPG.Personagens.Racas.Global;
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

		public ListaRacas() { }

		public static List<Raca> GetRacasGlobal()
		{
			if (RacasGlobal == null)
			{
				RacasGlobal = new List<Raca>
				{
					new Humano(),
					new Elfo(),
					new Anao()
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
					new Humano(),
					new Elfo(),
					new Anao(),
					new Esqueleto(),
					new Goblin(),
					new Orc(),
					new Kobold(),
					new Homem_Rato(),
					new Warg(),
					new Gnoll(),
				};
			}
			return RacasOponente;
		}

		public static Raca RandomOponente()
		{
			return GetRacasOponente()[new Random().Next(GetRacasOponente().Count)];
		}
	}
}