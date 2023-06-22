using projeto1_RPG.Principal;
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
            Console.WriteLine("Bem vindo ao jogo! \n Vamos começar a aventura!");
            Console.WriteLine("Qual seu nome: ");
            //nome

            Console.WriteLine("Selecione uma raça:");
            string[] opcoesRaca = {
                "Anão",
                "Elfo",
                "Humano" };
            int raca = Menu.MostrarOpcoes(opcoesRaca, "Raça: ");

            Console.WriteLine("Selecione uma classe:");
            string[] opcoesClasse = { };
            int classe = Menu.MostrarOpcoes(opcoesClasse, "Classe: ");
        }
    }
}