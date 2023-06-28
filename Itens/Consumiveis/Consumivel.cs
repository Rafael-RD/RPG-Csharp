using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Consumiveis
{
    internal abstract class Consumivel : Item
    {

        public Consumivel(int id, string nome, string descricao, int valor) : base(id, nome, descricao, valor) 
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

    }
}
