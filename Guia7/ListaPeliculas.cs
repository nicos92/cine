using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guia7.Properties;

namespace Guia7
{
    public static class ListaPeliculas
    {
        public static List<Pelicula> peliculas = new List<Pelicula>{
            new Pelicula("Lilo Y Stitch", Resources.LIOYSTITCH, true),
            new Pelicula("Ado", Resources.ADO, false),
            new Pelicula("Bailarina", Resources.BAILARINA, true),
            new Pelicula("Dan da dan", Resources.DANDADAN, true),
            new Pelicula("La hora de la desaparición", Resources.DESAPARICION, false),
            new Pelicula("Destino final", Resources.DESTINOFINAL, true),
            new Pelicula("Donde está el policia", Resources.DONDEESTAELPOLICIA, true),
            new Pelicula("Entrenando a tu dragon", Resources.DRAGON, true),
            new Pelicula("Elio", Resources.ELIO, false),
            new Pelicula("Exorcismo", Resources.EXORCISMO, true),
            new Pelicula("Exterminio", Resources.EXTERMINIO, true),
            new Pelicula("F1", Resources.F1, false),
            new Pelicula("Hope on the stage", Resources.HOPEONTHESTAGE, true),
            new Pelicula("Jurassic Word", Resources.JURASICWORD, true),
            new Pelicula("Karate Kid", Resources.KARATEKID, true),
            new Pelicula("Mazeltov", Resources.MAZELTOV, true),
            new Pelicula("Minecraft", Resources.MINECRAFT, true),
            new Pelicula("Misericordia", Resources.MISERICORDIA, true),
            new Pelicula("Nuevos vengadores", Resources.NUEVOSVENGADORES, true),
            new Pelicula("Los Pitufos", Resources.PITUFOS, true),
            new Pelicula("Mision imposible", Resources.MISIONIMPOSIBLE, true),
            new Pelicula("Se lo que hicieron el verano pasado", Resources.SELOQUEHICIERON, true),
            new Pelicula("Something Beautiful", Resources.SOMETHING, false),
            new Pelicula("Superman", Resources.SUPERMAN, true),
            new Pelicula("Tipos malos", Resources.TIPOSMALOS, true),
            new Pelicula("Viernes de locos", Resources.VIERNESDELOCOS, false)
        };

       
    }
}
