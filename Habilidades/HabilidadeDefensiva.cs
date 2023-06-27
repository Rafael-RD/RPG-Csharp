using projeto1_RPG.Principal;
using projeto1_RPG.Personagens.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
    internal abstract class HabilidadeDefensiva : Habilidade
    {
        public HabilidadeDefensiva(int id, string nome, string descricao, int custo, string[] classes, bool usarAliado = true, bool usarProprio = false) : base(id, nome, descricao, custo, classes)
        {
            UsarAliado = usarAliado;
            UsarProprio = usarProprio;
        }

        public override void Usar(Personagem origem, Personagem alvo)
        {
            base.Usar(origem, alvo);
        }
    }
}