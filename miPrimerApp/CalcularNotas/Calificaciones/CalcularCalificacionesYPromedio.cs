namespace CalcularNotas.Calificaciones
{
    /// <summary>
    /// Leer tres calificaciones y calcular el promedio. Si el promedio es igual o 
    /// superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.
    /// </summary>
    public class CalcularCalificacionesYPromedio
    {
        /// <summary>
        /// Calcula las calificaciones y promedia
        /// </summary>
        public void CalificacionesPromedio()
        {
            //Declarando variables

            decimal calificacion1 = 0;
            decimal calificacion2 = 0;
            decimal calificacion3 = 0;
            decimal promedio = 0;
            string linea = string.Empty;

            //Solicitando datos al usuario

            try
            {
                Console.WriteLine("Por favor digite la primera calificación: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: {linea}");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion1))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }
                calificacion1 = Convert.ToDecimal(linea);

                Console.WriteLine("Por favor digite la segunda calificación: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: {linea}");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion2))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }
                calificacion2 = Convert.ToDecimal(linea);

                Console.WriteLine("Por favor digite la tercera calificación: ");
                linea = Console.ReadLine();


                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: {linea}");
                    return;
                }

                if (!decimal.TryParse(linea, out calificacion3))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }
                calificacion3 = Convert.ToDecimal(linea);

                promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine($"El estudiante ha aprobado con: { promedio } :)");
                }
                else
                {
                    Console.WriteLine($"El estudiante ha reprobado con { promedio }  :(");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} ejecutando el programa");
            }

        }
    }
}
