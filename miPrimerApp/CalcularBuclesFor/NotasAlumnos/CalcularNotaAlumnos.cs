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
            int cantidad = 0;
            int calificacion = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite cuantas notas serán calculadas: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if(!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. { linea }");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Ingrese la calificacion: {i}");
                    calificacion = Convert.ToInt32(Console.ReadLine());

                    if (calificacion >= 7)
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
