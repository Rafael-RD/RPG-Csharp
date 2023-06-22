using projeto1_RPG.Personagens.Racas;
using projeto1_RPG.Personagens.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens
{
	internal class Oponente : Personagem
	{
		public Oponente(Raca raca, Classe classe) : base(raca, classe) { }

        public override AcaoTurno EscolherAcao()
        {
            int chance = new Random().Next(1, 5);

            if (chance == 1) return AcaoTurno.Defender;
            if (chance == 2) return AcaoTurno.Habilidades;
            return AcaoTurno.Atacar;
        }

        public override Habilidade? SelecionarHabilidade()
        {
            int opcao;
            if (Habilidades.Count == 0) return null;
            if (Habilidades.Count == 1) opcao = 0;
            else opcao = new Random().Next(0, Habilidades.Count-1);

            if (!Classe.ConsegueUsar(Habilidades[opcao])) return null;
            return Habilidades[opcao];
        }

        public override Personagem? SelecionarAlvo(List<Personagem> fila)
        {
            List<Personagem> lista = fila.FindAll(x => x is Jogador);
            if (lista.Count == 1) return lista[0];

            Random random = new Random();
            return lista[random.Next(0, lista.Count-1)];
        }
	}
}