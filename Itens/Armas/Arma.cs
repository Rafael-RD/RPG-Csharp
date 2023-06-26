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

        public Arma(int id, string nome, string descricao, int valor, string catElemental, string catFisica, int danoMinimo, int danoMaximo) : base(id, nome, descricao, valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Ataque = new Ataque(new Categoria(catElemental, catFisica), danoMinimo, danoMaximo);
        }
    }
}