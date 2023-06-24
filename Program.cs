using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Personagens.Racas.Global;
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
			//inicio
			Console.WriteLine("Bem vindo ao jogo!\n Vamos começar a aventura!");
			//criação personagem
			Console.WriteLine("Qual seu nome: ");

			Console.WriteLine("Selecione uma raça: \n 1-Anão\n 2-Elfo\n 3-Humano");
			int RaçaEscolhida = int.Parse(Console.ReadLine());

			Console.WriteLine("Selecione uma classe: \n 1-Guerreiro\n 2-Ladrão\n 3-Mago");
			int ClasseEscolhida = int.Parse(Console.ReadLine());
			Console.WriteLine("Todo heroí tem uma arma, vamos encontrar a perfeita para você!");
			if (ClasseEscolhida == 1)
			{
				Console.WriteLine("1 - Espada de ferro \n 2 - Machado de ferro");
			}
			else if (ClasseEscolhida == 2)
			{
				Console.WriteLine("1 - Adaga de ferro \n 2 - Arco de madeira");
			}
			else if (ClasseEscolhida == 3)
			{
				Console.WriteLine("1 - Cajado de madeira \n 2 - Livro de magia");
			}
			else
			{
				Console.WriteLine("Numero desconhecido, tente denovo");
			}

			Console.WriteLine("O que é isso?? \n OH NÃO! \n Um monstro, luite com ele!");
			//inicio batalha

			//fim batalha
			while (true)
			{
			   // Console.WriteLine("Você conseguiu derrortar o " + nomedomonstro + "ele te deu " + xp + " de experiencia");
				Console.WriteLine("O que deseja fazer agora? \n 1-Explorar (encontro aleatório) 2-Ver personagem \n 3-Ver inventário \n 0-Sair");
				int escolha = int.Parse(Console.ReadLine());
				if (escolha == 0)
				{
					break;
				}
			}
		}
	}
}