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
        public enum MomentoAplicar
        {
            Nenhum,
            AposCalcularDano
        }
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public MomentoAplicar Momento { get; protected set; }
        public int Turnos { get; set; }

        public Efeito()
        {
            this.Nome = String.Empty;
            this.Descricao = String.Empty;
        }
    }
}