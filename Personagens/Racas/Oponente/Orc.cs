using projeto1_RPG.Personagens.Racas;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Personagens.Racas.Oponente
{
	internal class Orc : Raca
	{
		public Orc() : base()
		{
			Id = 13;
			Nome = "Orc";
			Atributos.Forca = 3;
			Atributos.Destreza = 1;
			Atributos.Inteligencia = 1;
			Atributos.Resistencia = 2;
			Atributos.Saude = 2;
		}
	}
}