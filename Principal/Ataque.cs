using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
	internal class Ataque
	{
		public Categoria Categoria { get; set; }
		public int DanoMinimo { get; set; }
		public int DanoMaximo { get; set; }

		public Ataque(Categoria categoria, int danoMinimo, int danoMaximo)
		{
			Categoria = categoria ?? new Categoria();
			DanoMinimo = danoMinimo;
			DanoMaximo = danoMaximo;
		}

		public int CalcDano()
		{
			return new Random().Next(DanoMinimo, DanoMaximo + 1);
		}

	}
}
