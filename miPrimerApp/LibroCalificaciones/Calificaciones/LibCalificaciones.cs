namespace LibroCalificaciones.Calificaciones
{
    public class LibCalificaciones
    {
        private string nombreCurso;

        public LibCalificaciones(string nombre)
        {
            NombreCurso = nombre;
        }

        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }
            set
            {
                nombreCurso = value;
            }
        }
        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al Libro Calificaciones para \n{0}!", NombreCurso );
        }
    }
}
