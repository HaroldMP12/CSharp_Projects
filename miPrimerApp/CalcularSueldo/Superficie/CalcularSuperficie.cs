using System.ComponentModel;

namespace CalcularSueldo.Superficie
{
    /// <summary>
    /// Calcular lados de una superficie y imprimir su valor
    /// </summary>
    public class CalcularSuperficie
    {
        /// <summary>
        /// Calcula los lados de la superficie
        /// </summary>
        public void Calcular()
        {
            //Declaramos las variables

            int lado = 0;
            int superficie = 0;
            string linea = string.Empty;

            //Solicitar al usuario por teclado

            try
            {

                Console.WriteLine("Por favor digite el valor del lado: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El lado es requerido");
                    return;
                }

                if (!int.TryParse(linea, out lado))
                {
                    Console.WriteLine($"El valor del lado es inválido {linea}");
                    return;
                }

                //Calculando la superficie

                superficie = (lado * lado);

                Console.WriteLine($"El valor de la superficie es: { superficie }");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa");
            }
        }
    }
}
