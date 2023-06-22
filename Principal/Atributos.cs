using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Principal
{
	internal class Atributos
	{
		public double Forca { get; set; }
		public double Destreza { get; set; }
		public double Inteligencia { get; set; }
		public double Resistencia { get; set; }
		public double Saude { get; set; }
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