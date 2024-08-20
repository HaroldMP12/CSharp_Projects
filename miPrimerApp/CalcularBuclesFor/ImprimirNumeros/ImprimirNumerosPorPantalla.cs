namespace CalcularBuclesFor.ImprimirNumeros
{
    /// <summary>
    /// Este objeto imprime por pantalla los numeros del 1 al 100
    /// </summary>
    public class ImprimirNumerosPorPantalla
    {
        /// <summary>
        /// Imprime los numeros del 1 al 100 mostrandolos por pantalla cuando se inicie el programa
        /// </summary>
        public void ImprimirNumeros()
        {
            try
            {
                for(int i = 1; i <= 100; i++)
                {
                    Console.WriteLine($"Estamos en el número: { i } del bucle.");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
