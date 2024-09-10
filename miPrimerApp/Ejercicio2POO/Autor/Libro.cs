using System;
namespace Ejercicio2POO.Autor
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Libro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Páginas: {Paginas}");
        }
        public bool EsLargo()
        {
            return Paginas > 500;
        }
        static void Main(string [] args)
        {
            Libro libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 417);
            libro.MostrarInformacion();
            Console.WriteLine($"¿Es largo?: {libro.EsLargo()}");
        }
    }

}
