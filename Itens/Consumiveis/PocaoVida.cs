using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens.Consumiveis
{
    internal class PocaoVida : Consumivel
    {
        public int VidaRestaurada { get; set; }

        public PocaoVida(int id, string nome, string descricao, int valor, int vidaRestaurada) : base(id, nome, descricao, valor)
        {
            VidaRestaurada = vidaRestaurada;
        }

        public override void Usar(Personagem origem, Personagem alvo)
        {
            alvo.PtsSaudeAtual = Math.Min(alvo.PtsSaudeAtual + VidaRestaurada, alvo.Atributos.PtsSaudeMax);
            Console.WriteLine($"{origem.Nome} usou {this.Nome} e recuperou {VidaRestaurada} pontos de vida.");

        }
    }
}
