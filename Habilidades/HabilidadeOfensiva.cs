using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
	internal class HabilidadeOfensiva : Habilidade
	{
		public Ataque Ataque { get; set; }

		public HabilidadeOfensiva(int id, string nome, string descricao, int custo, string[] classes, Ataque ataque, bool usarAliado=false, bool usarProprio=false) : base(id, nome, descricao, custo, classes)
		{
			Ataque = ataque;
			UsarAliado = usarAliado;
			UsarProprio = usarProprio;
		}

		public override void Usar(Personagem origem, Personagem alvo)
		{
			alvo.ReceberAtaque(origem, this.Ataque);
			base.Usar(origem, alvo);
		}
	}
}