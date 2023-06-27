using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Combates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
	internal class EfeitoDefesa : Efeito, IGatilhoDanoAposArmadura
	{
		public int PercReducao { get; protected set; }

		public EfeitoDefesa() : base("Defesa", "Reduz o dano recebido.", 1)
		{
			this.PercReducao = 50;
		}

		public int DanoAposArmadura(Personagem alvo, int dano)
		{
			int reducao = (int)Math.Floor(dano * ((float)this.PercReducao / 100));
			Console.WriteLine($"[{this.Nome}] Dano reduzido em {this.PercReducao}% ({reducao}).");
			return dano - reducao;
		}
	}
}
