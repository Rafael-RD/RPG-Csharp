using projeto1_RPG.Principal;
using projeto1_RPG.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto1_RPG.Itens;

namespace projeto1_RPG.Personagens.Classes
{
	internal abstract class Classe
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public Atributos Atributos { get; set; }
		public List<Habilidade> Habilidades { get; set; }
		public List<Item> KitInicial { get; set; }
		public int Dinheiro { get; set; }

		public Classe()
		{
			Nome = string.Empty;
			Atributos = new Atributos();
			Habilidades = new List<Habilidade>();
			KitInicial = new List<Item>();
		}

		public bool ConsegueUsar(Habilidade habilidade)
		{
			// TODO: Validar se consegue usar a habilidade (se tem nível/mana o suficiente)
			return false;
		}
	}
}