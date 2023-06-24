using projeto1_RPG.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens
{
	internal abstract class Item
	{
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public int Valor { get; set; }
		public bool UsarAliado { get; set; }

		public Item(string nome, string descricao, int valor)
		{
			Nome = nome;
			Descricao = descricao;
			Valor = valor;
			UsarAliado = true;
		}

		public bool PodeUsar(Personagem personagem)
		{
			string msg;
			return PodeUsar(personagem, out msg);
		}

		public virtual bool PodeUsar(Personagem personagem, out string msg)
		{
			msg = String.Empty;
			return true;
		}

		public abstract void Usar(Personagem origem, Personagem alvo);
	}
}