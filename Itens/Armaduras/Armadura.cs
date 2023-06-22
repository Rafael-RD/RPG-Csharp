using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Armaduras
{
    internal class Armadura : Item
    {
        public Categoria Resistencia { get; set; }
        public Categoria Fraqueza { get; set; }
        public int ReducaoDano { get; set; }

        public Armadura(string nome, string descricao, int valor, int reducaoDano) : base(nome, descricao, valor)
        {
            Resistencia = new Categoria();
            Fraqueza = new Categoria();
            ReducaoDano = reducaoDano;
        }
    }
}