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
        private bool Fugiu { get; set; }

        public Combate()
        {
            this.Jogadores = new List<Personagem>();
            this.Oponentes = new List<Personagem>();
            this.Fila = new FilaCombate();
        }

        public void AddJogador(Personagem jogador)
        {
            this.Jogadores.Add(jogador);
            this.Fila.Adicionar(jogador);
        }

        public void AddOponente(Personagem oponente)
        {
            this.Oponentes.Add(oponente);
            this.Fila.Adicionar(oponente);
        }

        public void IniciarCombate()
        {
            Fugiu = false;
            this.Fila.Iniciar();
            Console.WriteLine("-----------------");
            Console.WriteLine("Combate iniciado!");

            // Apresenta ordem
            Console.WriteLine("Ordem: ");
            foreach (Personagem p in this.Fila.Ordem) { Console.Write($"- {p.Nome}"); }

            // Loop principal do combate
            while ((!Fugiu) && (!this.Fila.Terminou()))
            {
                IniciarTurno(this.Fila.Proximo());
            }

            // Resultado do combate
            ApresentarResultado();
        }

        private void IniciarTurno(Personagem personagem)
        {
            Console.WriteLine($"\nTurno de {personagem.Nome}");
            personagem.IniciouTurno();

            // Sai do loop somente quando executou uma ação
            bool sair = false;
            while (!sair)
            {
                switch (personagem.EscolherAcao())
                {
                    case Personagem.AcaoTurno.Atacar: sair = Atacar(personagem); break;
                    case Personagem.AcaoTurno.Defender: sair = Defender(personagem); break;
                    case Personagem.AcaoTurno.Habilidades: sair = UsarHabilidade(personagem); break;
                    case Personagem.AcaoTurno.Fujir: sair = Fugir(personagem); break;
                    default: Console.WriteLine("Ação não identificada!"); break;
               }
            }
        }

        private bool Atacar(Personagem personagem)
        {
            Personagem? alvo = personagem.SelecionarAlvo(this.Fila.Ordem);
            if (alvo == null) return false;

            Console.WriteLine($"{personagem.Nome} ataca {alvo.Nome}.");
            personagem.Atacar(alvo);

            if (alvo.SaudeAtual <= 0) this.Fila.Remover(alvo);
            return true;
        }

        private bool Defender(Personagem personagem)
        {
            Console.WriteLine($"{personagem.Nome} está se defendendo.");
            personagem.Defender();
            return true;
        }

        private bool UsarHabilidade(Personagem personagem)
        {
            Habilidade? habilidade = personagem.SelecionarHabilidade();
            if (habilidade == null) return false;

            Personagem? alvo = personagem.SelecionarAlvo(this.Fila.Ordem);
            if (alvo == null) return false;

            Console.WriteLine($"{personagem.Nome} usou {habilidade.Nome} em {alvo.Nome}.");
            personagem.Habilidade(habilidade, alvo);

            if (alvo.SaudeAtual <= 0) this.Fila.Remover(alvo);
            return true;
        }

        private bool Fugir(Personagem personagem)
        {
            // Calcula fuga com base na destreza dos lados
            int dexJogadores = (int)Math.Round(this.Fila.Jogadores.Sum(j => j.Atributos.Destreza));
            int dexOponentes = (int)Math.Round(this.Fila.Oponentes.Sum(o => o.Atributos.Destreza));
            int fuga = (new Random().Next(1, dexJogadores + dexOponentes));

            Fugiu = (fuga < dexJogadores);
            return true;
        }

        private void ApresentarResultado()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Combate encerrado!");

            string resultado;
            if (Fugiu) resultado = "Fuga";
            else if (this.Fila.Jogadores.Count == 0) resultado = "Derrota";
            else resultado = "Vitória";

            Console.WriteLine($"Resultado: {resultado}");

            int totalExp = 0;
            foreach (Personagem p in this.Oponentes)
            {
                if (!this.Fila.Oponentes.Contains(p)) totalExp += p.Exp;
            }

            int exp;
            foreach (Jogador j in this.Fila.Jogadores)
            {
                exp = totalExp / this.Fila.Jogadores.Count;
                j.Exp += exp;
                Console.WriteLine($"{j.Nome} ganhou experiência: {exp}.");
            }

            Console.Write("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}