namespace CalcularLotePiezas.Promedio
{
    /// <summary>
    /// Este objeto calcula las notas ingresadas por el usuario, las suma y muestra el promedio 
    /// </summary>
    public class CalcularPromedioWhile
    {
        /// <summary>
        /// Calcula las cantidad de notas las suma y promedia y muestra los resultados
        /// </summary>
        public void CalcularPromedio()
        {
            //Declarando las variables
            decimal suma = 0;
            decimal promedio = 0;
            decimal cantidad = 0;
            decimal valor = 0;
            decimal i = 1;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la cantidad de números a ingresar: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido.");
                    return;
                }

                if(!decimal.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                while ( i <= cantidad)
                {
                    Console.WriteLine($"Por favor digite el valor: {i}");
                    valor = Convert.ToInt32(Console.ReadLine());
                    suma = suma + valor;
                    i++;
                }

                promedio = (suma / cantidad);

                Console.WriteLine($"El valor de la suma es: {suma} y el promedio: {promedio} ");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
