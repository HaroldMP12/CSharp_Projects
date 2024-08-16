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

            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal valor3 = 0;
            decimal valor4 = 0;
            decimal valor5 = 0;
            decimal valor6 = 0;
            decimal valor7 = 0;
            decimal valor8 = 0;
            decimal valor9 = 0;
            decimal valor10 = 0;
            decimal suma = 0;
            decimal promedio = 0;
            decimal totalValores = 0;
            string linea = string.Empty;


            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Por favor digite el valor: {i}");
                    linea = Console.ReadLine();

                    if(string.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine($"El valor es requerido.");
                        return;
                    }

                    totalValores += Convert.ToDecimal(linea);
                }

                suma = suma + totalValores;
                promedio = suma / 10;

                Console.WriteLine($"El valor de la suma es: {suma} y el promedio: { promedio } "); 
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
