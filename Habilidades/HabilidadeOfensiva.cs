using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
	internal abstract class HabilidadeOfensiva : Habilidade
	{
		public Ataque Ataque { get; set; }

		public HabilidadeOfensiva(string nome, int custo, Ataque ataque) : base(nome, custo)
		{
			Ataque = ataque;
			UsarAliado = false;
		}

		public override void Usar(Personagem origem, Personagem alvo)
		{
			alvo.ReceberAtaque(origem, this.Ataque);
		}
	}
}