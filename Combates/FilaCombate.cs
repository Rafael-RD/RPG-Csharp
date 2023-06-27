using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Combates
{
	internal class FilaCombate
	{
		public List<Jogador> Jogadores { get; private set; }
		public List<Oponente> Oponentes { get; private set; }

		public int Rodada { get; private set; }
		private int IdxProximo { get; set; }
		private int RodadaFuga { get; set; }
		private double ChanceFugirRodada { get; set; }
		private static readonly Random _rnd = new Random();

		public List<Personagem> Ordem { get; private set; }

		public FilaCombate()
		{
			this.Jogadores = new List<Jogador>();
			this.Oponentes = new List<Oponente>();
			this.Ordem = new List<Personagem>();
		}

		public void Adicionar(Personagem personagem)
		{
			if (personagem is Jogador) this.Jogadores.Add((Jogador)personagem);
			else if (personagem is Oponente) this.Oponentes.Add((Oponente)personagem);

			this.Ordem.Add(personagem);
		}

		public void Remover(Personagem p)
		{
			int idx = this.Ordem.IndexOf(p);
			if (idx <= this.IdxProximo) this.IdxProximo--;

			this.Ordem.RemoveAt(idx);
			if (p is Jogador) this.Jogadores.Remove((Jogador)p);
			if (p is Oponente) this.Oponentes.Remove((Oponente)p);
		}

		public void Iniciar()
		{
			this.Ordem.Sort(delegate (Personagem p1, Personagem p2) { return p2.Atributos.Destreza.CompareTo(p1.Atributos.Destreza); });
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

		public double GetChanceFugir()
		{
			if (RodadaFuga != Rodada)
			{
				RodadaFuga = Rodada;
				int dexJogadores = this.Jogadores.Sum(j => j.Atributos.Destreza + _rnd.Next(-2, 2));
				int dexOponentes = this.Oponentes.Sum(o => o.Atributos.Destreza + _rnd.Next(-2, 2));

				ChanceFugirRodada = (double)dexJogadores/(dexJogadores + dexOponentes);
			}

			return ChanceFugirRodada;
		}

		public bool TentaFugir()
		{
			return (_rnd.NextDouble() < this.GetChanceFugir());
		}
	}
}
