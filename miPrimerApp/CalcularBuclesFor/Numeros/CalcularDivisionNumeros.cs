namespace CalcularBuclesFor.Numeros
{
    /// <summary>
    /// Este objeto cuenta los numeros de un conjunto y muestra cuales son divisibles entre 3 o por 5
    /// </summary>
    public class CalcularDivisionNumeros
    {
        /// <summary>
        /// Calcula los numeros del conjunto y verifica cuales son divisibles por 3 o por 5
        /// </summary>
        public void CalcularNumeros()
        {
            //Declarando las variables

            int numeros = 0;
            int cantidad = 0;
            string linea = string.Empty;
            string divisibles = string.Empty;
            string noDivisibles = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la cantidad de números a verificar: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. {linea} ");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Ingrese el { i } valor");
                    int valor = Convert.ToInt32(Console.ReadLine());

                    if ((valor % 3 == 0) || (valor % 5 == 0))
                    {
                        numeros++;
                        divisibles += valor + "  ";
                    }
                    else
                    {
                        noDivisibles += valor + "  ";    
                    }
                }
                Console.WriteLine($"Los valores: {divisibles} son divisibles por 3 o por 5.");
                Console.WriteLine($"Los valores: { noDivisibles } no son divisibles por 3 o por 5");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecucion del programa.");
            }
        }
    }
}
