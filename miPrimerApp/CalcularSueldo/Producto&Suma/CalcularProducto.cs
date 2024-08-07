namespace CalcularSueldo.Producto_Suma
{
    /// <summary>
    /// Calcular el producto y la suma de dos enteros.
    /// </summary>
    public class CalcularProducto
    {
        /// <summary>
        /// Mostrar la suma y el producto apartir de dos enteros.
        /// </summary>
        public void CalcularProductoSuma()
        {
            //Declaramos variables

            int num1 = 0;
            int num2 = 0;
            int producto = 0;
            int suma = 0;
            string linea = string.Empty;

            try
            {   
                //Solicitar al usuario los números por teclado

                Console.WriteLine("Por favor digite el primer número: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: { linea }");
                }

                //Validando el tipo de dato

                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine($"Valor incorrecto : { linea }");
                    return;
                }

                num1 = Convert.ToInt32(linea);

                Console.WriteLine("Por favor digite el segundo número: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: { linea }");
                }

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine($"Valor incorrecto: { linea }");
                    return;
                }

                num2 = Convert.ToInt32(linea);

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"El resultado de la suma es: { suma } y el producto es: { producto }");
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa.");
            }
        }
    }
}
