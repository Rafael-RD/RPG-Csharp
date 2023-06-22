using projeto1_RPG.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Combate
{
    internal class FilaCombate
    {
        public List<Personagem> Jogadores { get; private set; }
        public List<Personagem> Oponentes { get; private set; }

        public int Rodada { get; private set; }
        private int IdxProximo { get; set; }
        public List<Personagem> Ordem { get; private set; }

        public FilaCombate()
        {
            this.Jogadores = new List<Personagem>();
            this.Oponentes = new List<Personagem>();
            this.Ordem = new List<Personagem>();
        }

        public void Adicionar(Personagem personagem, bool jogador)
        {
            if (jogador) this.Jogadores.Add(personagem);
            else this.Oponentes.Add(personagem);

            this.Ordem.Add(personagem);
        }

        public void Remover(Personagem p)
        {
            int idx = this.Ordem.IndexOf(p);
            if (idx <= this.IdxProximo) this.IdxProximo--;

            this.Ordem.RemoveAt(idx);
            this.Oponentes.Remove(p);
            this.Jogadores.Remove(p);
        }

        public void Iniciar()
        {
            this.Ordem.Sort(delegate(Personagem p1, Personagem p2) { return p2.Atributos.Destreza.CompareTo(p1.Atributos.Destreza); });
            this.Rodada = 1;
            this.IdxProximo = 0;
        }

        public bool Terminou()
        {
            return (this.Jogadores.Count == 0) || (this.Oponentes.Count == 0);
        }

        public Personagem Proximo()
        {
            if (this.IdxProximo >= this.Ordem.Count)
            {
                this.Rodada++;
                this.IdxProximo = 0;
            }
            return this.Ordem[this.IdxProximo++];
        }
    }
}