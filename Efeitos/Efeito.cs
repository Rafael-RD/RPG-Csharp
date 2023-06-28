using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
	internal abstract class Efeito
	{
		public string Nome { get; protected set; }
		public string Descricao { get; protected set; }
		public int Turnos { get; set; }

		public Efeito(string nome, string descricao, int turnos)
		{
			this.Nome = nome;
			this.Descricao = descricao;
			this.Turnos = turnos;
		}
	}
}
