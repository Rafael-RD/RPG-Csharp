using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
	internal class Atributos
	{
		public int Forca { get; set; }
		public int Destreza { get; set; }
		public int Inteligencia { get; set; }
		public int Resistencia { get; set; }
		public int Saude { get; set; }
		public Atributos() { }
		public void SomarAtributos(Atributos atributos)
		{
			Forca += atributos.Forca;
			Destreza += atributos.Destreza;
			Inteligencia += atributos.Inteligencia;
			Resistencia += atributos.Resistencia;
			Saude += atributos.Saude;
		}
	}
}