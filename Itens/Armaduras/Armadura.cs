using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
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

		private int AplicarFraqueza(int reducao)
		{
			// Diminui resistência em 50%
			return (reducao / 2);
		}

		private int AplicarResistencia(int reducao)
		{
			// Aumenta resistência em 50%
			return (int)Math.Floor(reducao * 1.5);
		}

		public int CalculaReducao(Ataque ataque)
		{
			int reducao = ReducaoDano;

			// Fraqueza
			if ((Fraqueza != null) &&
				((Fraqueza.Elemental.Equals(ataque.Categoria.Elemental)) ||
				 (Fraqueza.Fisica.Equals(ataque.Categoria.Fisica))))
				reducao = AplicarFraqueza(reducao);

			// Resistência
			if ((Resistencia != null) &&
				((Resistencia.Elemental.Equals(ataque.Categoria.Elemental)) ||
				 (Resistencia.Fisica.Equals(ataque.Categoria.Fisica))))
				reducao = AplicarResistencia(reducao);

			return reducao;
		}

		public override void Usar(Personagem origem, Personagem alvo)
		{
			if (this == alvo.Armadura)
			{
				alvo.Armadura = null;
				Console.WriteLine($"{alvo.Nome} removeu a armadura.");
			} else {
				alvo.Armadura = this;
				Console.WriteLine($"{alvo.Nome} equipou a armadura {this.Nome}.");
			}
		}
	}
}
