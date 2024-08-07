namespace CalcularSueldo.SumaYPromedio
{
    /// <summary>
    /// Calcular cuatro valores numericos sumandolos y mostrando su promedio
    /// </summary>
    public class CalcularSumaYPromedio
    {
        /// <summary>
        /// Calcula los cuatro numeros los suma y los promedia
        /// </summary>
        public void CalcularSumaPromedio()
        {
            //Declaramos las variables

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma = 0;
            float promedio = 0;
            string linea = string.Empty;

            //Solicitar al usuario los valores

            try
            {

                Console.Write("Ingrese el primer valor: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }

                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo valor: ");
                linea = Console.ReadLine() ;

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }

                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el tercer valor: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out num3))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }

                num3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el cuarto valor: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out num4))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }

                num4 = Convert.ToInt32(Console.ReadLine());

                suma = (num1 + num2 + num3 + num4);
                promedio = suma / 4.0f;

                Console.WriteLine($"El resultado de la suma es: {suma} y el promedio es: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa.");
            }
        }
    }
}
