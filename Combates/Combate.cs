using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Habilidades;
using projeto1_RPG.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Combates
{
	internal class Combate
	{
		private List<Jogador> Jogadores { get; set; }
		private List<Oponente> Oponentes { get; set; }
		private FilaCombate Fila { get; set; }
		private bool Fugiu { get; set; }

		private static string _linha_separar { get; set; } = new string('-', 20);

		public Combate()
		{
			this.Jogadores = new List<Jogador>();
			this.Oponentes = new List<Oponente>();
			this.Fila = new FilaCombate();
		}

		public void AddPersonagem(Personagem personagem)
		{
			if (personagem is Jogador) this.Jogadores.Add((Jogador)personagem);
			else if (personagem is Oponente) this.Oponentes.Add((Oponente)personagem);
			this.Fila.Adicionar(personagem);
		}

		public void IniciarCombate()
		{
			Fugiu = false;
			this.Fila.Iniciar();
			Console.WriteLine(_linha_separar);
			Console.WriteLine("Combate iniciado!");

			// Apresenta ordem
			Console.Write("Ordem: ");
			foreach (Personagem p in this.Fila.Ordem) { Console.Write($"{p.Nome} | "); }
			Console.WriteLine();

			// Loop principal do combate
			while ((!Fugiu) && (!this.Fila.Terminou()))
			{
				ComecarTurno(this.Fila.Proximo());
			}

			// Resultado do combate
			ApresentarResultado();
		}

		private void ComecarTurno(Personagem personagem)
		{
			Console.WriteLine(_linha_separar);
			Console.WriteLine($"Turno de {personagem.Nome}. Saúde: {personagem.PtsSaudeAtual}/{personagem.Atributos.PtsSaudeMax}. {personagem.Classe.GetDescPtsHabili()}: {personagem.PtsHabiliAtual}/{personagem.Atributos.PtsHabiliMax}");
			
			if (!personagem.IniciouTurno()) return;

			// Sai do loop somente quando executou uma ação
			bool sair = false;
			while (!sair)
			{
				Console.WriteLine();
				switch (personagem.EscolherAcao())
				{
					case Personagem.AcaoTurno.Atacar: sair = Atacar(personagem); break;
					case Personagem.AcaoTurno.Defender: sair = Defender(personagem); break;
					case Personagem.AcaoTurno.Habilidades: sair = UsarHabilidade(personagem); break;
					case Personagem.AcaoTurno.Inventario: sair = UsarItem(personagem); break;
					case Personagem.AcaoTurno.Fugir: sair = Fugir(personagem); break;
					default: Console.WriteLine("Ação não identificada!"); break;
				}
			}
		}

		private bool Atacar(Personagem personagem)
		{
			Personagem alvo = personagem.SelecionarAlvo(this.Fila.Ordem, false);
			if (alvo == null) return false;

			Console.WriteLine($"{personagem.Nome} ataca {alvo.Nome}.");
			personagem.Atacar(alvo);

			if (alvo.PtsSaudeAtual <= 0) this.Fila.Remover(alvo);
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
			Habilidade habilidade = personagem.SelecionarHabilidade();
			if (habilidade == null) return false;

			Personagem alvo = personagem.SelecionarAlvo(this.Fila.Ordem, habilidade.UsarAliado);
			if (alvo == null) return false;

			Console.WriteLine($"{personagem.Nome} usa {habilidade.Nome} em {alvo.Nome}.");
			habilidade.Usar(personagem, alvo);

			if (alvo.PtsSaudeAtual <= 0) this.Fila.Remover(alvo);
			return true;
		}

		private bool UsarItem(Personagem personagem)
		{
			Item item = personagem.SelecionarItem();
			if (item == null) return false;

			Personagem alvo = personagem.SelecionarAlvo(this.Fila.Ordem, item.UsarAliado);
			if (alvo == null) return false;

			if (alvo == personagem) Console.WriteLine($"{personagem.Nome} usa {item.Nome}.");
			else Console.WriteLine($"{personagem.Nome} usa {item.Nome} em {alvo.Nome}.");
			item.Usar(personagem, alvo);

			if (alvo.PtsSaudeAtual <= 0) this.Fila.Remover(alvo);
			return true;
		}

		private bool Fugir(Personagem personagem)
		{
			Console.WriteLine($"Chance: {(this.Fila.GetChanceFugir()*100).ToString("N2")}%");
			Console.Write($"Deseja tentar fugir (s/n)? ");
			if (!("s").Equals(Console.ReadLine().ToLower())) return false;

			Fugiu = this.Fila.TentaFugir();

			if (Fugiu) Console.WriteLine($"{personagem.Nome} fugiu da batalha.");
			else Console.WriteLine($"{personagem.Nome} não conseguiu fugir.");

			return true;
		}

		private void ApresentarResultado()
		{
			Console.WriteLine(_linha_separar);
			Console.WriteLine("Combate encerrado!");

			string resultado;
			if (Fugiu) resultado = "Fuga";
			else if (this.Fila.Jogadores.Count == 0) resultado = "Derrota";
			else resultado = "Vitória";

			Console.WriteLine($"Resultado: {resultado}");

			int totalExp = 0;
			int totalDinheiro = 0;
			foreach (Oponente p in this.Oponentes)
			{
				if (!this.Fila.Oponentes.Contains(p))
				{
					totalExp += p.CalcExpRecompensa();
					totalDinheiro += p.Dinheiro;
				}
			}

			int exp;
			int dinheiro;
			foreach (Jogador j in this.Fila.Jogadores)
			{
				exp = totalExp / this.Fila.Jogadores.Count;
				dinheiro = totalDinheiro / this.Fila.Jogadores.Count;

				if (dinheiro > 0) Console.WriteLine($"{j.Nome} ganhou dinheiro: {dinheiro}.");
				if (exp > 0) Console.WriteLine($"{j.Nome} ganhou experiência: {exp}.");

				j.Dinheiro += dinheiro;
				j.Nivel.ExpAtual += exp;
				if (j.Nivel.ExpAtual >= j.Nivel.ExpProxNivel)
				{
					j.Nivel.SetNivel(j.Nivel.NivelAtual + 1);
					Console.WriteLine($"{j.Nome} alcançou o nível {j.Nivel.NivelAtual}!");
				}
			}

			Console.WriteLine(_linha_separar);
			Console.WriteLine("Pressione qualquer tecla para continuar.");
			Console.ReadKey();
		}
	}
}
