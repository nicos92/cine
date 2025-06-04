using System.Drawing;

namespace Guia7
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public Image Imagen { get; set; }
        public bool EnCartelera { get; set; }

        public Pelicula( string titulo, Image imagen, bool enCartelera)
        {
            Titulo = titulo;
            Imagen = imagen;
            EnCartelera = enCartelera;
        }
    }
}