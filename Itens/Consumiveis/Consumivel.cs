using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Consumiveis
{
    internal class Consumivel : Item
    {
        public int VidaRestaurada { get; set; }
        public int ManaRestaurada { get; set; }

        public Consumivel(int id, string nome, string descricao, int valor) : base(id, nome, descricao, valor) 
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }
        public override void Usar(Personagem origem, Personagem alvo)
        {
            alvo.Consumivel = this;
            Console.WriteLine($"{alvo.Nome} usou {this.Nome}.");
            
        }
    }
}
