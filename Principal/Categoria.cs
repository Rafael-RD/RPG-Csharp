using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
	internal class Categoria
	{
		public string Elemental { get; set; }
		public string Fisica { get; set; }

		public Categoria(string elemental = null, string fisica = null)
		{
			Elemental = elemental ?? String.Empty;
			Fisica = fisica ?? String.Empty;
		}
	}
}