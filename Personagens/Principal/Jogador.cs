using projeto1_RPG.Principal;
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
	internal class Jogador : Personagem
	{
		public Jogador(Raca raca, Classe classe, int nivel = 1) : base(raca, classe, nivel) { }

		public override AcaoTurno EscolherAcao()
		{
			Console.WriteLine("Selecione uma ação:");
			string[] opcoes = {
				"Atacar",
				"Defender",
				"Habilidades",
				"Inventario"
			};
			switch (Menu.MostrarOpcoes(opcoes, "Ação: ", "Fugir"))
			{
				case 0: return AcaoTurno.Atacar;
				case 1: return AcaoTurno.Defender;
				case 2: return AcaoTurno.Habilidades;
				case 3: return AcaoTurno.Inventario;
				default: return AcaoTurno.Fugir;
			}
		}

		public override Habilidade SelecionarHabilidade()
		{
			Console.WriteLine($"\nSelecione uma habilidade:");
			int opcao = Menu.MostrarOpcoes(Classe.Habilidades.Select(x => x.Nome).ToArray(), "Habilidade: ", "Voltar");
			if (opcao >= 0)
			{
				if (Classe.ConsegueUsar(Classe.Habilidades[opcao])) return Classe.Habilidades[opcao];
				Console.WriteLine($"Não é possível usar {Classe.Habilidades[opcao].Nome}.");
			}
			return null;
		}

		public override Personagem SelecionarAlvo(List<Personagem> fila, Habilidade habilidade)
		{
			List<Personagem> lista = fila.FindAll(x => x is Oponente);

			if (lista.Count == 1) return lista[0];

			Console.WriteLine($"\nSelecione um alvo:");
			int opcao = Menu.MostrarOpcoes(lista.Select(x => $"{x.Nome} ({x.SaudeAtual}/{x.Atributos.Saude})").ToArray(), "Alvo: ", "Voltar");

			if (opcao >= 0) return lista[opcao];
			else return null;
		}

		public override Personagem SelecionarAlvo(List<Personagem> fila, Item item)
		{
			if (item is Itens.Armas.Arma) return this;
			if (item is Itens.Armaduras.Armadura) return this;

			List<Personagem> lista = fila.FindAll(x => x is Jogador);

			if (lista.Count == 1) return lista[0];

			Console.WriteLine($"\nSelecione um alvo:");
			int opcao = Menu.MostrarOpcoes(lista.Select(x => $"{x.Nome} ({x.SaudeAtual}/{x.Atributos.Saude})").ToArray(), "Alvo: ", "Voltar");

			if (opcao >= 0) return lista[opcao];
			else return null;
		}

		private bool ItemEquipado(Item item)
		{
			return (item == this.Arma) || (item == this.Armadura);
		}

		public override Item SelecionarItem()
		{
			Console.WriteLine($"\nSelecione um item:");
			int opcao = Menu.MostrarOpcoes(Inventario.Select(x => (ItemEquipado(x) ? $"*{x.Nome} (Equipado)" : $" {x.Nome}")).ToArray(), "Item: ", "Voltar");
			if (opcao >= 0)
			{
				Item i = Inventario[opcao];

				if (i == Arma) Console.WriteLine($"A arma {i.Nome} já está equipada.");
				else if (i == Armadura) Console.WriteLine($"A armadura {i.Nome} já está equipada!");
				else return i;
			}
			return null;
		}
	}
}
