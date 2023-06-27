using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Combates;
using projeto1_RPG.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto1_RPG.Itens.Consumiveis;

namespace projeto1_RPG
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ciração do personagem

			Console.Write("Bem-vindo ao jogo! Vamos começar a aventura?");
			Console.Write("\n\n");
			Console.Write("----- CRIAÇÃO DE PERSONAGEM -----");
			Console.Write("\n\n");
			Console.WriteLine("Selecione a raça do seu personagem:");
			string[] opcoes = ListaRacas.GetRacasGlobal().Select(x => x.Nome).ToArray();
			int racaEscolhida = Menu.MostrarOpcoes(opcoes, "> ");
			Raca racaJogador = (ListaRacas.GetRacasGlobal()[racaEscolhida]);
			Console.Write('\n');
			Console.WriteLine("Selecione a classe do seu personagem:");
			opcoes = ListaClasses.GetClasses().Select(x => x.Nome).ToArray();
			int classeEscolhida = Menu.MostrarOpcoes(opcoes, "> ");
			Classe classeJogador = (ListaClasses.GetClasses()[classeEscolhida]);
			Console.Write('\n');
			Console.Write("Informe o nome do seu personagem:\n> ");
			string nome = Console.ReadLine();

			Jogador j1 = new Jogador(nome, racaJogador, classeJogador);

			Console.Write('\n');

			Console.WriteLine("Resumo do seu personagem:");
			Console.WriteLine($"Nome: {j1.Nome}");
			Console.WriteLine($"Raça: {j1.Raca.Nome}  ||  Classe: {j1.Classe.Nome}");
			Console.WriteLine($"Pontos de vida: {j1.PtsSaudeAtual}  ||  Pontos de habilidade: {j1.PtsHabiliAtual}");
			Console.WriteLine($"Arma: {j1.Arma.Nome}");
			Console.WriteLine($"Peças de ouro: {j1.Dinheiro}");

			//Console.WriteLine("Você está satisfeito com esse personagem?");

			//inicio batalha
			GeradorOponentes b = new GeradorOponentes();
			List<Personagem> listaJogadores = new List<Personagem>();
			listaJogadores.Add(j1);
			//fim batalha


			bool sair = false;
			List<Personagem> listaOponentes;
			Combate combate;
			while (!sair)
			{
				// Console.WriteLine("Você conseguiu derrortar o " + nomedomonstro + "ele te deu " + xp + " de experiencia");
				Console.WriteLine("O que deseja fazer?");
				opcoes = new string[]{
								"Explorar",
								"Ver inventário",
								"Ver personagem"
						};
				int opcao = Menu.MostrarOpcoes(opcoes, "Opção:", "Sair");
				switch (opcao)
				{
					case 0:
						Console.WriteLine();
						Console.WriteLine("Você escolheu explorar");
						listaOponentes = b.MontarLista(listaJogadores);

						combate = new Combate();
						foreach (Personagem oponente in listaOponentes)
						{
							combate.AddPersonagem(oponente);
						}
						combate.AddPersonagem(j1);
						combate.IniciarCombate();
						break;


					case 1:
						Console.WriteLine();
						Console.WriteLine("Você escolheu ver inventário");
						Item item = j1.SelecionarItem();
						if (item != null)
						{
							item.Usar(j1, j1);
							if(item is Consumivel) {j1.Inventario.Remove(item); }
						}
                        break;

					case 2:
						Console.WriteLine("Você escolheu ver o personagem");
						break;
					default:
						sair = true;
						break;
				}
			}
		}
	}
}
