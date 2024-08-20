namespace CalcularBuclesFor.PromedioValores
{
    /// <summary>
    /// Este objeto carga 10 valores por teclado y muestra posteriormente su suma y promedio
    /// </summary>
    public class CalcularSumaPromedioValores
    {
        /// <summary>
        /// Calcula la suma y promedio de los valores ingresados
        /// </summary>
        public void CalcularPromedio()
        {
            //Declarando variables

            int suma = 0;
            decimal promedio = 0;
            int cantidad = 0;
            int valor = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la cantidad de números a ingresar: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. { linea }");
                    return;
                }
                cantidad = Convert.ToInt32(linea);

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Por favor digite el valor: {i}");
                    valor = Convert.ToInt32(Console.ReadLine());

                    suma = suma + valor;
                }

                promedio = (suma / cantidad);

                Console.WriteLine($"El valor de la suma es: {suma} y el promedio: { promedio } "); 
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
