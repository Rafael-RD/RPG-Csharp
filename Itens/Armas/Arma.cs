using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
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

		public override void Usar(Personagem origem, Personagem alvo)
		{
			if (this == alvo.Arma)
			{
				alvo.Arma = null;
				Console.WriteLine($"{alvo.Nome} removeu a arma.");
			} else {
				alvo.Arma = this;
				Console.WriteLine($"{alvo.Nome} equipou a arma {this.Nome}.");
			}
		}

		public virtual void Atacar(Personagem origem, Personagem alvo)
		{
			alvo.ReceberAtaque(origem, this.Ataque);
		}
	}
}
