using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens
{
	internal class Oponente : Personagem
	{
		public Oponente(Raca raca, Classe classe, int nivel = 1) : base(raca, classe, nivel)
		{
			this.Dinheiro /= 2;
		}

		public override AcaoTurno EscolherAcao()
		{
			int chance = new Random().Next(1, 10 + 1);

			if (chance <= 2) return AcaoTurno.Defender;
			if (chance == 3) return AcaoTurno.Habilidades;
			if (chance == 4) return AcaoTurno.Inventario;
			return AcaoTurno.Atacar;
		}

		public override Habilidade SelecionarHabilidade()
		{
			int opcao;
			if (Classe.Habilidades.Count == 0) return null;
			if (Classe.Habilidades.Count == 1) opcao = 0;
			else opcao = new Random().Next(Classe.Habilidades.Count);

			if (!Classe.ConsegueUsar(Classe.Habilidades[opcao])) return null;
			return Classe.Habilidades[opcao];
		}

		public override Personagem SelecionarAlvo(List<Personagem> fila, Habilidade habilidade)
		{
			List<Personagem> lista = fila.FindAll(x => x is Jogador);
			if (lista.Count == 1) return lista[0];

			return lista[new Random().Next(lista.Count)];
		}

		public override Personagem SelecionarAlvo(List<Personagem> fila, Item item)
		{
			if (item is Itens.Armas.Arma) return this;
			if (item is Itens.Armaduras.Armadura) return this;

			List<Personagem> lista = fila.FindAll(x => x is Oponente);
			if (lista.Count == 1) return lista[0];

			return lista[new Random().Next(lista.Count)];
		}

		public int CalcExpRecompensa()
		{
			const int EXP_BASE = 100;
			return (int)Math.Floor((EXP_BASE * Math.Sqrt(Nivel.NivelAtual + 1)) - EXP_BASE);
		}

		public override Item SelecionarItem()
		{
			int opcao;
			if (Inventario.Count == 0) return null;
			if (Inventario.Count == 1) opcao = 0;
			else opcao = new Random().Next(Inventario.Count);

			Item i = Inventario[opcao];
			if (i == this.Arma) return null;
			if (i == this.Armadura) return null;

			return Inventario[opcao];
		}
	}
}
