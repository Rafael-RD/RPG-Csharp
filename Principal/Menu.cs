using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
	internal class Menu
	{

		/* Retorna índice [0..N] que o usuário selecionou dentre as "opcoes", "itemZero" retornará -1 */
		public static int MostrarOpcoes(string[] opcoes, string msg, string itemZero = null)
		{
			// Teste de dados de entrada
			if (opcoes.Length == 0)
			{
				return -1;
			}

			// Imprime opções
			for (int i = 0; i < opcoes.Length; i++)
			{
				ImprimeItem(i + 1, opcoes[i]);
			}

			int primeiraOpcao = 1;
			if (itemZero != null)
			{
				ImprimeItem(0, itemZero);
				primeiraOpcao = 0;
			}

			string opcao;
			int conversao;
			int retorno = -1;
			do
			{
				// Solicita opção para o usuário
				Console.Write(msg);
				opcao = Console.ReadLine() ?? String.Empty;

				// Verifica se é um número
				if (!int.TryParse(opcao, out conversao))
				{
					Console.WriteLine($"Não foi possível converter \"{opcao}\" para um número.\n");
				}
				else
				// Verifica se é uma opção válida
				if ((conversao < primeiraOpcao) || (conversao > opcoes.Length))
				{
					Console.WriteLine($"O número informado ({conversao}) não é uma opção válida.\n");
				}
				else
				{
					retorno = conversao;
				}

			} while (retorno == -1);

			return (retorno - 1);
		}

		private static void ImprimeItem(int item, string descricao)
		{
			Console.WriteLine($"{item} - {descricao}");
		}
	}
}