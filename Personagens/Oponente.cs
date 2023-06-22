using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using projeto1_RPG.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens
{
	internal class Oponente : Personagem
	{
		public Oponente(Raca raca, Classe classe, int nivel = 1) : base(raca, classe, nivel) { }

        public override AcaoTurno EscolherAcao()
        {
            int chance = new Random().Next(1, 5+1);

            if (chance == 1) return AcaoTurno.Defender;
            if (chance == 2) return AcaoTurno.Habilidades;
            return AcaoTurno.Atacar;
        }

        public override Habilidade SelecionarHabilidade()
        {
            int opcao;
            if (Classe.Habilidades.Count == 0) return null;
            if (Classe.Habilidades.Count == 1) opcao = 0;
            else opcao = new Random().Next(0, Classe.Habilidades.Count);

            if (!Classe.ConsegueUsar(Classe.Habilidades[opcao])) return null;
            return Classe.Habilidades[opcao];
        }

        public override Personagem SelecionarAlvo(List<Personagem> fila, Habilidade habilidade)
        {
            List<Personagem> lista = fila.FindAll(x => x is Jogador);
            if (lista.Count == 1) return lista[0];

            return lista[new Random().Next(0, lista.Count)];
        }
	}
}