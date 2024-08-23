namespace CalcularBuclesFor.Suma
{
    /// <summary>
    /// Este objeto captura 10 numeros e imprime los ultimos 5 digitos ingresados.
    /// </summary>
    public class CalcularSumaNumeros
    {/// <summary>
    /// Calcula la suma de los ultimos 5 numeros ingresados y muestra por pantalla
    /// </summary>
        public void CalcularSuma()
        {
            //Declarando variables

            int suma = 0;
            int cantidad = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la cantidad de numeros: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. {linea}");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Ingrese el { i } numero: ");
                    int numerosIngresados = Convert.ToInt32(Console.ReadLine());

                    if(i > cantidad - 5)
                    {
                        suma += numerosIngresados;
                    }
                }

                Console.WriteLine($"El resultado de la suma de los ultimos valores son: { suma }");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecucion del programa");
            }
        }
    }
}
