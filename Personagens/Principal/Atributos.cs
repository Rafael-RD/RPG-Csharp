using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Principal
{
	internal class Atributos
	{
		public int Forca { get; set; }
		public int Destreza { get; set; }
		public int Inteligencia { get; set; }
		public int Resistencia { get; set; }
		public int PtsSaudeMax;
		public int PtsHabiliMax { get; set; }

		public Atributos() { }

		public void SetAtributos(int forca, int destreza, int inteligencia, int resistencia, int ptsSaudeMax, int ptsHabiliMax)
		{
			Forca = forca;
			Destreza = destreza;
			Inteligencia = inteligencia;
			Resistencia = resistencia;
			PtsSaudeMax = ptsSaudeMax;
			PtsHabiliMax = ptsHabiliMax;
		}
		public void SomarAtributos(Atributos atributos)
		{
			Forca += atributos.Forca;
			Destreza += atributos.Destreza;
			Inteligencia += atributos.Inteligencia;
			Resistencia += atributos.Resistencia;
			PtsSaudeMax += atributos.PtsSaudeMax;
			PtsHabiliMax += atributos.PtsHabiliMax;
		}
	}
}
