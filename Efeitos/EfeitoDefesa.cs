using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
    internal class EfeitoDefesa : Efeito, IEfeitoAposCalcularDano
    {
        public int PercReducao { get; protected set; }

        public EfeitoDefesa() : base()
        {
            this.Nome = "Defesa";
            this.Turnos = 1;
            this.PercReducao = 50;
        }

        public int AposCalcularDano(int dano)
        {
            return (int)Math.Floor((float)dano * (this.PercReducao / 100));
        }
    }
}