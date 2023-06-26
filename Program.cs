using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Combates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ciração do personagem

			Console.WriteLine("Bem vindo ao jogo!\nVamos começar a aventura!");
			Console.WriteLine("Qual seu nome: ");
			string nome = Console.ReadLine();
			Console.WriteLine("Selecione uma raça:");
			string[] opcoes = ListaRacas.GetRacasGlobal().Select(x => x.Nome).ToArray();
			int racaEscolhida = Menu.MostrarOpcoes(opcoes, "Raça: ");
			Raca racajogador = (ListaRacas.GetRacasGlobal()[racaEscolhida]);

			Console.WriteLine();
			Console.WriteLine("Selecione uma classe: ");
			opcoes = ListaClasses.GetClasses().Select(x => x.Nome).ToArray();
			int classeEscolhida = Menu.MostrarOpcoes(opcoes, "Classe: ");
			Console.WriteLine();
			Classe classeJogador = (ListaClasses.GetClasses()[classeEscolhida]);

			Personagem p1 = new Jogador(nome, racajogador, classeJogador);

			Console.WriteLine();
			Console.WriteLine("Seu personagem ficou assim:");
			Console.WriteLine("Seu nome é: " + p1.Nome);
			Console.WriteLine("Sua raça é " + p1.Raca.Nome);
			Console.WriteLine("Sua classe é " + p1.Classe.Nome);
			Console.WriteLine("E sua arma é " + p1.Arma);
			Console.WriteLine();


			//inicio batalha
			GeradorOponentes b = new GeradorOponentes();
			List<Personagem> listaJogadores = new List<Personagem>();
			listaJogadores.Add(p1);
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
						foreach (Personagem item in listaOponentes)
						{
							combate.AddPersonagem(item);
						}
						combate.AddPersonagem(p1);
						combate.IniciarCombate();
						break;


					case 1:
						Console.WriteLine();
						Console.WriteLine("Você escolheu ver inventário");
						p1.SelecionarItem();
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
