namespace CalcularNotas.Promedio
{
    /// <summary>
    /// Programa que calcula 3 calificaciones e indica su promedio para saber si aprobo o no
    /// </summary>
    public class CalificacionesYPromedio
    {
        /// <summary>
        /// Calcula las calificaciones y el promedio, Si el promedio es igual o superior a siete, 
        /// imprime un mensaje indicando que el alumno ha aprobado
        /// </summary>
        public void PromedioNotas()
        {
            //Declarando variables

            decimal calificacion1 = 0;
            decimal calificacion2 = 0;
            decimal calificacion3 = 0;
            decimal promedio = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la primera calificacion: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion es requerida.");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion1))
                {
                    Console.WriteLine("La calificacion es inválida.");
                    return;
                }
                else
                {
                    calificacion1 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Por favor digite la segunda calificacion: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion es requerida.");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion2))
                {
                    Console.WriteLine("La calificacion es inválida.");
                    return;
                }
                else
                {
                    calificacion2 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Por favor digite la tercera calificacion: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("La calificacion es requerida.");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion3))
                {
                    Console.WriteLine("La calificacion es inválida.");
                    return;
                }
                else
                {
                    calificacion3 = Convert.ToInt32(linea);
                }

                promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine($"Felicidades!! has aprobado con: { promedio } :)");
                }
                else
                {
                    Console.WriteLine($"El estudiante ha reprobado! con: { promedio } :(");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
