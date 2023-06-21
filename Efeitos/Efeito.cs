using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
    internal class Efeito
    {
        public String Nome { get; protected set; }
        public int Turnos { get; protected set; }
        public bool Percentual { get; protected set; }
        public Atributos Atributos { get; private set; }

        public Efeito()
        {
            this.Nome = String.Empty;
            this.Atributos = new Atributos();
        }
    }
}