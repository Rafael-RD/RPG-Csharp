using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
    internal class EfeitoDefesa : Efeito
    {
        public EfeitoDefesa() : base()
        {
            this.Nome = "Defesa";
            this.Turnos = 1;
            this.Percentual = true;
            this.Atributos.Resistencia = 50;
        }
    }
}