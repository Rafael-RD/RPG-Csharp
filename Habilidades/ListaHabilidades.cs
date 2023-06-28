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
        public static List<Habilidade> HabilidadesOfensivas { get; set; } = new List<Habilidade>()
        {
            new HabilidadeOfensiva(1, "Bola de Fogo", "Bola de Fogo", 1, new[] { "Mago" }, new Ataque(new Categoria(Categoria.Elemento.Fogo, Categoria.Fisico.Magia), 10, 14), false, false),
            new HabilidadeOfensiva(2, "Raio Eletrico", "Raio Eletrico", 1, new[] { "Mago" }, new Ataque(new Categoria(Categoria.Elemento.Eletrico, Categoria.Fisico.Magia), 10, 14), false, false),
            new HabilidadeOfensiva(3, "Halito Gelado", "Halito Gelado", 1, new[] { "Mago" }, new Ataque(new Categoria(Categoria.Elemento.Gelo, Categoria.Fisico.Magia), 10, 14), false, false),
            new HabilidadeOfensiva(4, "Golpe Furtivo", "Golpe Furtivo", 1, new[] { "Ladrão" }, new Ataque(new Categoria(Categoria.Elemento.Neutro, Categoria.Fisico.Perfurante), 10, 20), false, true),
            new HabilidadeOfensiva(5, "Inflingir Ferimento", "Inflingir Ferimento", 1, new[] { "Clérigo" }, new Ataque(new Categoria(Categoria.Elemento.Divino, Categoria.Fisico.Magia), 8, 12), false, false),
            new HabilidadeOfensiva(6, "Ataque Impulsionado", "Ataque Impulsionado", 1, new[] { "Guerreiro" }, new Ataque(new Categoria(Categoria.Elemento.Neutro, Categoria.Fisico.Impacto), 12, 18), false, false)
        };
        public static List<Habilidade> HabilidadesDefensivas { get; set; } = new List<Habilidade>()
        {

        };
    }
}
