namespace CalcularNotas
{
    /// <summary>
    /// Programa que solicite al usuario dos números y, si el primer número es más grande, 
    /// calcule y muestre su suma y resta, De lo contrario, calculará y mostrará su producto y cociente
    /// </summary>
    public class Calificaciones
    {
        /// <summary>
        /// Calcula y muestra su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.
        /// </summary>
        public void CalcularNumeros()

            //Declarando variables
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal suma = 0;
            decimal resta = 0;
            decimal producto = 0;
            decimal division = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite el primer número: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("Num 1 es requerido.");
                    return;
                }

                if (!decimal.TryParse(linea , out num1))
                {
                    Console.WriteLine("Num 1 es inválido.");
                    return;
                }
                else
                {
                    num1 = Convert.ToInt32(linea);
                }

                Console.WriteLine("Por favor digite el segundo número: ");
                linea = Console.ReadLine ();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("Num 2 es requerido.");
                    return;
                }

                if (!decimal.TryParse(linea, out num2))
                {
                    Console.WriteLine("Num 2 es inválido."); 
                    return;
                }
                else
                {
                    num2 = Convert.ToInt32(linea);  
                }

                if (num1 > num2)
                {
                    suma = (num1 + num2);
                    resta = (num1 - num2);
                    Console.WriteLine($"La suma es: { suma } y la resta es: { resta }");
                }
                else
                {
                    producto = (num1 * num2);
                    division = (num1 / num2);
                    Console.WriteLine($"El producto es: { producto } y la division es: { division }");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa.");
            }
        }
    }
}
