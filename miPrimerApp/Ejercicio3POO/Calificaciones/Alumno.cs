namespace Ejercicio3POO.Calificaciones
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        public Alumno(string nombre, string matricula, string carrera, List<int> calificaciones)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
            Calificaciones = calificaciones;
        }
        public double CalcularPromedio()
        {

            int suma = 0;

            for (int i = 0; i < Calificaciones.Count; i++)
            {
                suma += Calificaciones[i];
            }
            return (double)suma / Calificaciones.Count;
        }

        public void MostrarInformacion()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }

        static void Main(string[] args)
        {

            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };

            Alumno alumno = new Alumno("Ana Pérez", "AP00285", "Ingeniería de Software", calificaciones);

            alumno.MostrarInformacion();
        }

    }
}
