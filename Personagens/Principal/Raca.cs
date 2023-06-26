using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal abstract class Raca
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public Atributos Atributos { get; private set; }
		public int DinheiroMin { get; set; }
		public int DinheiroMax { get; set; }

		private static readonly Random _rnd = new Random();

		public Raca()
		{
			Nome = string.Empty;
			Atributos = new Atributos();
		}

		public int GetDinheiro()
		{
			int dinheiro = _rnd.Next(DinheiroMin, DinheiroMax + 1);
			return dinheiro;
		}
	}
}
