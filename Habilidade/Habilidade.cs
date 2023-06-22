using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidade
{
    internal class Habilidade : Ataque
    {
        public string Nome { get; set; }
        
        public Habilidade(string nome, string elemento, string categoria, int danoMinimo, int danoMaximo) : base(elemento, categoria, danoMinimo, danoMaximo)
        {
            Nome = nome;
        }
    }
}
