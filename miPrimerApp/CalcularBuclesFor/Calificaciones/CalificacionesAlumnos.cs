namespace CalcularBuclesFor.Calificaciones
{
	/// <summary>
	/// Este objeto es para calcular la suma y promedio de los estudiantes
	/// </summary>
    public class CalificacionesAlumnos
    {
        /// <summary>
        ///  Leer tres calificaciones y calcular el promedio
        /// </summary>

        public void CalcularCalificaciones()
        {
            //Declarando variables

            decimal totalNota = 0;
            decimal promedio = 0;
            int cantidadNotas = 0;
            string linea = string.Empty;

            try
			{
                Console.WriteLine("Ingrese la cantidad de notas a promediar:  ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido. { linea }");
                    return;
                }

                if(!int.TryParse(linea, out cantidadNotas))
                {
                    Console.WriteLine($"El valor es inválido. { linea } "); 
                    return;
                }

                cantidadNotas = Convert.ToInt32(linea);

				for (int i = 1; i <= cantidadNotas; i++)
                {
                    Console.WriteLine($"Ingrese la nota: {i}");
                    linea = Console.ReadLine();
                    totalNota += Convert.ToDecimal(linea);
                }

                promedio = totalNota / cantidadNotas;

                //Operadores terniarios para la reducción de código

                string mensaje = promedio >= 7 ? $"Aprobado con: { promedio }" 
                                               : $"No aprobado, con: { promedio }";
                Console.WriteLine(mensaje);

                //if (promedio >= 7)
                //{
                //    Console.WriteLine($"Aprobado con: {promedio}");
                //}
                //else
                //{
                //    Console.WriteLine($"No aprobado, con: { promedio }");
                //}

            }
			catch (Exception ex)
			{
				Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa.");
			}
        }
    }
}
