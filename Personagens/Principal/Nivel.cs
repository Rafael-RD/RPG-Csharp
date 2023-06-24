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
		private int ExpBase { get; set; } = 100;
		public int ExpAtual { get; set; }
		public int ExpProxNivel { get; private set; }

		public Nivel(int nivel = 1)
		{
			SetNivel(nivel);
		}

		public void SetNivel(int nivel)
		{
			NivelAtual = nivel;
			ExpAtual = Math.Max(ExpAtual, (int)Math.Floor((ExpBase * Math.Pow(2, nivel - 1)) - ExpBase));
			ExpProxNivel = (int)Math.Floor(ExpBase * Math.Pow(2, nivel - 1));
		}
		public void AvancarNivel()
		{
			//ExpAtual -= ExpProxNivel;
			SetNivel(NivelAtual + 1);
		}
	}
}
