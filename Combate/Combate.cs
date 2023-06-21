using projeto1_RPG.Principal;
using projeto1_RPG.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Combate
{
    internal class Combate
    {
        private List<Personagem> Jogadores { get; set; }
        private List<Personagem> Oponentes { get; set; }
        private FilaCombate Fila { get; set; }

        private const int ACAO_ATACAR = 0;
        private const int ACAO_DEFENDER = 1;
        private const int ACAO_HABILIDADE = 2;
        private const int ACAO_FUGIR = 3;

        public Combate()
        {
            this.Jogadores = new List<Personagem>();
            this.Oponentes = new List<Personagem>();
            this.Fila = new FilaCombate();
        }

        public void AddJogador(Personagem jogador)
        {
            this.Jogadores.Add(jogador);
            this.Fila.Adicionar(jogador, true);
        }

        public void AddOponente(Personagem oponente)
        {
            this.Oponentes.Add(oponente);
            this.Fila.Adicionar(oponente, false);
        }

        public ResultadoCombate IniciarCombate()
        {
            this.Fila.Iniciar();
            while (!this.Fila.Terminou())
            {
                IniciarTurno(this.Fila.Proximo());
            }
            ResultadoCombate resultado = CalcularResultado();

            foreach (Personagem jogador in this.Fila.Jogadores)
            {
                jogador.Exp += resultado.Exp / this.Fila.Jogadores.Count;
                // jogador.Dinheiro += resultado.Dinheiro / this.Fila.Jogadores.Count; // TODO: Entregar o dinheiro
            }

            return resultado;
        }

        private bool IsJogador(Personagem personagem)
        {
            return this.Jogadores.Contains(personagem);
        }

        private int BuscaAcaoJogador()
        {
            Console.WriteLine("Selecione uma ação:");
            string[] opcoes = {
                "Atacar",
                "Defender",
                "Habilidades"
            };
            return Menu.MostrarOpcoes(opcoes, "Ação: ", "Fugir");
        }

        private int BuscaAcaoNPC()
        {
            Random random = new Random();
            int chance = random.Next(1, 5);

            if (chance == 1) return ACAO_DEFENDER;
            if (chance == 2) return ACAO_HABILIDADE;
            return ACAO_ATACAR;
        }

        private void IniciarTurno(Personagem personagem)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine($"\nTurno de {personagem.Nome}");

                int acao;
                if (IsJogador(personagem)) acao = BuscaAcaoJogador();
                else acao = BuscaAcaoNPC();

                switch (acao)
                {
                    case ACAO_ATACAR: sair = Atacar(personagem); break;
                    case ACAO_DEFENDER: sair = Defender(personagem); break;
                    case ACAO_HABILIDADE: sair = Habilidade(personagem); break;
                   default: sair = Fugir(personagem); break;
                }
            }
        }
        public bool Atacar(Personagem personagem)
        {
            Personagem? alvo = null;

            if (IsJogador(personagem))
            {
                if (this.Oponentes.Count == 1)
                {
                    alvo = this.Oponentes[0];
                }
                else
                {
                    Console.WriteLine($"\nQual inimigo deseja atacar?");
                    int opcao = Menu.MostrarOpcoes(this.Oponentes.Select(j => $"{j.Nome} ({j.SaudeAtual}/{j.Atributos.Saude})").ToArray(), "Alvo: ", "Voltar");
                    if (opcao >= 0) alvo = this.Oponentes[opcao];
                }
            } else {
                if (this.Jogadores.Count == 1)
                {
                    alvo = this.Jogadores[0];
                }
                else
                {
                    Random random = new Random();
                    alvo = this.Jogadores[random.Next(0, this.Jogadores.Count-1)];
                }
            }

            if (alvo != null)
            {
                //personagem.Atacar(alvo); // TODO: Atacar

                if (alvo.SaudeAtual <= 0)
                {
                    this.Fila.Remover(alvo);
                }
                return true;
            }
            return false;
        }
        public bool Defender(Personagem personagem)
        {
            // TODO: Defender
            return true;
        }
        public bool Habilidade(Personagem personagem)
        {
            // TODO: Selecionar habilidade
            // TODO: Usar habilidade
            return false;
        }
        public bool Fugir(Personagem personagem)
        {
            // TODO: Fugir
            return true;
        }

        private ResultadoCombate CalcularResultado()
        {
            ResultadoCombate resultado = new ResultadoCombate();

            resultado.Vitoria = (this.Fila.Oponentes.Count == 0) && (this.Fila.Jogadores.Count > 0);
            foreach (Personagem p in this.Oponentes)
            {
                if (!this.Fila.Oponentes.Contains(p))
                {
                    resultado.Exp += p.Exp;
                    // resultado.Dinheiro += p.Dinheiro; // TODO: Somar o dinheiro no resultado
                }
            }

            return resultado;
        }
    }
}