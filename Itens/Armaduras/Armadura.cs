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
        public Defesa Resistencia { get; set; }
        public Defesa Fraqueza { get; set; }

        public Armadura(string nome, string descricao, int valor, int reducaoDano) : base(nome, descricao, valor)
        {
            Resistencia = new Defesa(reducaoDano);
            Fraqueza = new Defesa(0);
        }
    }
}