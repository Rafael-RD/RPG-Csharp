using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Armas
{
    internal class Arma : Item
    {
        public Ataque Ataque { get; set; }

        public Arma(string nome, string descricao, int valor, string elemento, string categoria, int danoMinimo, int danoMaximo) : base(nome, descricao, valor)
        {
            Nome = nome;
            Descricao = descricao;
            Ataque = new Ataque(elemento, categoria, danoMinimo, danoMaximo);
        }
    }
}