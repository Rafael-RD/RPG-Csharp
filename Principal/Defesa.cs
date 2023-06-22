using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
    internal class Defesa
    {
        public string Elemento { get; set; }
        public string Categoria { get; set; }
        public int ReducaoDano { get; set; }

        public Defesa(int reducaoDano)
        {
            Elemento = String.Empty;
            Categoria = String.Empty;
            ReducaoDano = reducaoDano;
        }
    }
}