using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Principal;
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
                "Habilidades"
            };
            switch (Menu.MostrarOpcoes(opcoes, "Ação: ", "Fugir"))
            {
                case 0: return AcaoTurno.Atacar;
                case 1: return AcaoTurno.Defender;
                case 2: return AcaoTurno.Habilidades;
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
    }
}