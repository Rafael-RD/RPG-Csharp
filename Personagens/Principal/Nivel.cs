using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal class Nivel
	{
		public int NivelAtual { get; private set; }
		public int ExpBase { get; private set; } = 100;
		public int ExpAtual { get; set; }
		public int ExpProxNivel { get; private set; }
		public int ExpRecompensa { get; set; }
		public bool AvancouNivel { get; private set; } = false;

		public Nivel(int nivel = 1)
		{
			SetNivel(nivel);
		}

		public void SetNivel(int nivel)
		{
			NivelAtual = nivel;
			ExpAtual = Math.Max(ExpAtual, (int)Math.Floor((ExpBase * Math.Pow(2, nivel - 1)) - ExpBase));
			ExpProxNivel = (int)Math.Floor(ExpBase * Math.Pow(2, nivel - 1));
			ExpRecompensa = (int)Math.Floor((ExpBase * Math.Sqrt(nivel + 1)) - ExpBase);
		}

		public void CalcExperiencia()
		{
			int ExpRestante = ExpAtual - ExpProxNivel;
			if (ExpRestante >= 0)
			{
				AvancouNivel = true;
				SetNivel(NivelAtual + 1);
				ExpAtual = ExpRestante;
			}
			else
			{
				AvancouNivel = false;
			}
		}
	}
}
