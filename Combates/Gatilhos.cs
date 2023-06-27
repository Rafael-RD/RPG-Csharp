using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Combates
{
	interface IGatilhoDanoAposArmadura
	{
		int DanoAposArmadura(Personagem alvo, int dano);
	}

	interface IGatilhoPodeIniciarTurno
	{
		bool PodeIniciarTurno(Personagem alvo);
	}
}