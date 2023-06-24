using projeto1_RPG.Personagens;
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
			Humano r = new Humano();
			Guerreiro g = new Guerreiro();
			Jogador j1 = new Jogador(r, g, 1);
			//Jogador j2 = new Jogador(r, g, 2);

			Console.WriteLine($"{j1.Nivel.NivelAtual}, {j1.Atributos.Forca}");
			j1.AvancarNivel();
			Console.WriteLine($"{j1.Nivel.NivelAtual}, {j1.Atributos.Forca}");
			j1.AvancarNivel();
			Console.WriteLine($"{j1.Nivel.NivelAtual}, {j1.Atributos.Forca}");

			Console.ReadKey();
		}
	}
}