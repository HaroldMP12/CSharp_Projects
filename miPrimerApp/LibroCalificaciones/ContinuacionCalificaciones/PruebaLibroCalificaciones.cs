using LibroCalificaciones.Calificaciones;

namespace LibroCalificaciones.ContinuacionCalificaciones
{
    public class PruebaLibroCalificaciones
    {
        public static void Main (string[] args)
        {
            //LibCalificaciones miLibroCalificaciones = new LibCalificaciones ();

            LibCalificaciones libroCalificaciones1 = new LibCalificaciones("CS101 Introducción a la programación en C#");
            LibCalificaciones libroCalificaciones2 = new LibCalificaciones("CS102 Estructuras de datos en C#");

            Console.WriteLine("El nombre del curso de libroCalificaciones1 es: {0}",
            libroCalificaciones1.NombreCurso);

            Console.WriteLine("El nombre del curso de libroCalificaciones2 es: {0}",
                libroCalificaciones2.NombreCurso);
            //miLibroCalificaciones.MostrarMensaje();

            //Console.WriteLine("Por favor escriba el nombre del curso: ");
            //string elNombre = Console.ReadLine ();
            //miLibroCalificaciones.NombreCurso = elNombre;
            //Console.WriteLine();

            //miLibroCalificaciones.MostrarMensaje();
        }
    }
}
