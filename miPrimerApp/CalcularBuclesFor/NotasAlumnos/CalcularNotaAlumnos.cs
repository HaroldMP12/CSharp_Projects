using System.Numerics;

namespace CalcularBuclesFor.NotasAlumnos
{
    /// <summary>
    /// Este objeto lee 10 notas de alumnos y informa cual es mayor o menor
    /// </summary>
    public class CalcularNotaAlumnos
    {
        /// <summary>
        /// Calcula las notas de los alumnos e informa cuales son mayores o iguales y menores
        /// </summary>
        public void CalcularCalifEstudiantes()
        {
            //Declarando variables
            
            int aprobados = 0;
            int reprobados = 0;
            string linea = string.Empty;

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Ingrese la nota: {i}");
                    linea = Console.ReadLine();
                    int totalNotas = Convert.ToInt32(linea);

                    if (totalNotas >= 7)
                    {
                        aprobados++;
                    }
                    else
                    {
                        reprobados++;
                    }
                }

                Console.WriteLine($"La cantidad de aprobados mayores o iguales a 7 son: {aprobados}");
                Console.WriteLine($"La cantidad de reprobados menores a 7 son: {reprobados}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
