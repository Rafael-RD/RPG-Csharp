using projeto1_RPG.Habilidades;
using projeto1_RPG.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal class Oponente : Personagem
	{
		private static readonly Random _rnd = new Random();
		private bool AdicionarClasse { get; set; }

		public Oponente(string nome, Raca raca, Classe classe, int nivel = 1) : base(nome, raca, classe, nivel)
		{
			this.AdicionarClasse = true;
			this.Dinheiro /= 2;
		}

		public override AcaoTurno EscolherAcao()
		{
			int chance = _rnd.Next(1, 10 + 1);

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
			else opcao = _rnd.Next(Classe.Habilidades.Count);

			if (!Classe.Habilidades[opcao].PodeUsar(this)) return null;

			return Classe.Habilidades[opcao];
		}

		public override Personagem SelecionarAlvo(List<Personagem> fila, bool aliado)
		{
			List<Personagem> lista = fila.FindAll(x => (aliado) == (x is Oponente));
			if (lista.Count == 1) return lista[0];

			return lista[_rnd.Next(lista.Count)];
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
			else opcao = _rnd.Next(Inventario.Count);

			if (!Inventario[opcao].PodeUsar(this)) return null;

			return Inventario[opcao];
		}
	}
}