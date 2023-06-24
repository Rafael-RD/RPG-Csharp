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

		public Raca()
		{
			Nome = string.Empty;
			Atributos = new Atributos();
		}

		public int GetDinheiro()
		{
			int dinheiro = new Random().Next(DinheiroMin, DinheiroMax + 1);
			return dinheiro;
		}
	}
}