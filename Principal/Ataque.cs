using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
    internal class Ataque
    {
        public string Elemento { get; set; }
        public string Categoria { get; set; }
        public int DanoMinimo { get; set; }
        public int DanoMaximo { get; set; }

        public Ataque(string elemento, string categoria, int danoMinimo, int danoMaximo)
        {
            Elemento = elemento;
            Categoria = categoria;
            DanoMinimo = danoMinimo;
            DanoMaximo = danoMaximo;
        }

        public int CalcDano()
        {
            return new Random().Next(DanoMinimo, DanoMaximo+1);
        }

    }
}