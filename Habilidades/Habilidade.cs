using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
	internal abstract class Habilidade
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public int Custo { get; set; }
		public string[] Classes { get; set; }
		public bool UsarAliado { get; set; }
		public bool UsarProprio { get; set; }

        public Habilidade(int id, string nome, string descricao, int custo, string[] classes)
        {
			Id = id;
            Nome = nome;
			Descricao = descricao;
            Custo = custo;
            Classes = classes;
            UsarAliado = false;
            UsarProprio = false;
        }

        public bool PodeUsar(Personagem personagem)
		{
			string msg;
			return PodeUsar(personagem, out msg);
		}

		public virtual bool PodeUsar(Personagem personagem, out string msg)
		{
			msg = String.Empty;
			if (personagem.PtsHabiliAtual < Custo) msg="Sem pontos de habilidade";
			return (msg==String.Empty);
		}

		public virtual void Usar(Personagem origem, Personagem alvo)
		{
            origem.PtsHabiliAtual -= Custo;
        }
	}
}