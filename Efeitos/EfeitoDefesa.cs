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
        public int Percentual { get; protected set; }

        public EfeitoDefesa() : base()
        {
            this.Nome = "Defesa";
            this.Momento = MomentoAplicar.AposCalcularDano;
            this.Turnos = 1;
            this.Percentual = 50;
        }
    }
}