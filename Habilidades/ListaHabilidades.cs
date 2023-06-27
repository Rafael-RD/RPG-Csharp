using projeto1_RPG.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1_RPG.Habilidades
{
    internal class ListaHabilidades
    {
        public static List<Habilidade> HabilidadesOfensivas { get; set; } = new List<Habilidade>();
        public static List<Habilidade> HabilidadesDefensivas { get; set; } = new List<Habilidade>();

        public ListaHabilidades()
        {
            HabilidadesOfensivas.Add(new HabilidadeOfensiva(1, "Bola de Fogo", "Bola de Fogo", 10, new[] { "Mago" }, new Principal.Ataque(new Principal.Categoria(Categoria.Elemento.Fogo, Categoria.Fisico.Magia), 10, 14), false, false));
            HabilidadesOfensivas.Add(new HabilidadeOfensiva(2, "Raio Eletrico", "Raio Eletrico", 10, new[] { "Mago" }, new Principal.Ataque(new Principal.Categoria(Categoria.Elemento.Eletrico, Categoria.Fisico.Magia), 10, 14), false, false));
            HabilidadesOfensivas.Add(new HabilidadeOfensiva(3, "Halito Gelado", "Halito Gelado", 10, new[] { "Mago" }, new Principal.Ataque(new Principal.Categoria(Categoria.Elemento.Gelo, Categoria.Fisico.Magia), 10, 14), false, false));
            HabilidadesOfensivas.Add(new HabilidadeOfensiva(4, "Golpe Furtivo", "Golpe Furtivo", 5, new[] { "Ladrão" }, new Principal.Ataque(new Principal.Categoria(Categoria.Elemento.Neutro, Categoria.Fisico.Perfurante), 10, 20), false, true));
            HabilidadesOfensivas.Add(new HabilidadeOfensiva(5, "Inflingir Ferimento", "Inflingir Ferimento", 7, new[] { "Clérigo" }, new Principal.Ataque(new Principal.Categoria(Categoria.Elemento.Divino, Categoria.Fisico.Magia), 8, 12), false, false));
        }
    }
}
