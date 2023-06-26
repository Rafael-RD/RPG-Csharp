using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Itens
{
	internal abstract class Item
	{
        public int Id { get; set; }
        public string Nome { get; set; }
		public string Descricao { get; set; }
		public int Valor { get; set; }
		public bool UsarAliado { get; set; }

		public Item(int id, string nome, string descricao, int valor)
		{
            Id = id;
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
