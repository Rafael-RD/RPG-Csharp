using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
    internal class Categoria
    {
        public static class Elemento
        {
            public static readonly string Neutro = "Neutro";
            public static readonly string Fogo = "Fogo";
            public static readonly string Gelo = "Gelo";
            public static readonly string Eletrico = "Eletrico";
            public static readonly string Divino = "Divino";
            public static readonly string Trevas = "Trevas";
            public static readonly string Veneno = "Veneno";
        }
        public static class Fisico
        {
            public static readonly string Impacto = "Impacto";
            public static readonly string Cortante = "Cortante";
            public static readonly string Perfurante = "Perfurante";
        }

        public string Elemental { get; private set; }
        public string Fisica { get; private set; }

		public Categoria(string elemental = null, string fisica = null)
		{
			Elemental = elemental ?? String.Empty;
			Fisica = fisica ?? String.Empty;
		}
	}
}
