using projeto1_RPG.Personagens.Principal;
using projeto1_RPG.Combates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Efeitos
{
	internal class EfeitoCongelado : Efeito, IGatilhoPodeIniciarTurno
	{
		public EfeitoCongelado(int turnos) : base("Congelamento", "Impedido de iniciar o turno.", turnos) { }

		public bool PodeIniciarTurno(Personagem alvo)
		{
			Console.WriteLine($"[{this.Nome}] {alvo.Nome} perdeu o turno por estar congelado ({this.Turnos} {(this.Turnos == 1 ? "turno" : "turnos")}).");
			return false;
		}
	}
}
