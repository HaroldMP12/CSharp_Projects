using System.Runtime.CompilerServices;

namespace CalcularBuclesFor.Triangulo
{
    /// <summary>
    /// Este objeto calcula la dimension de un triangulo y cuenta cuales exceden de un limite
    /// </summary>
    public class CalcularDimensionTriangulo
    {
        /// <summary>
        /// Calcula la dimension de un triangulo y cuenta aquellos cuya área excede un valor límite.
        /// </summary>
        public void CalcularDimension()
        {
            //Declaracion de variables
            
            double noExcedeLimite = 0;
            double excedeLimite = 0;
            double area = 0;
            double s = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double valorLimite = 30.0;
            int cantidad = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor introduzca la cantidad de triangulos a evaluar: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if(!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. { linea }");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Introduzca las dimensiones del triangulo { i }");
                 
                    Console.WriteLine("Lado a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Lado b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Lado c: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    s = (a + b + c) / 2;
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                    if (area >= valorLimite)
                    {
                        excedeLimite++;
                    }
                    else
                    {
                        noExcedeLimite++;
                    }
                }
                Console.WriteLine($"Número de triángulos con área que excede el límite de: { valorLimite } el valor es: { excedeLimite }");
                Console.WriteLine($"Número de triangulos que no exceden el limite de: { valorLimite } la cantidad es: { noExcedeLimite } ");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecucion del programa.");
            }
        }
    }
}
