using System.Runtime.CompilerServices;

namespace CalcularBaseTriangulo.Triangulo
{
    /// <summary>
    /// Este objeto calcula la base, altura y área de un triangulo
    /// </summary>
    public class CalcularBATriangulo
    {
        /// <summary>
        /// Calcula base, altura, area de n triangulos ingresados
        /// </summary>
        public void CalcularTriangulo()
        {
            //Declarando variables

           
            int valorLimite = 0;
            int cantidad = 0;   
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite la cantidad de triangulos a calcular: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es invalido. {linea}");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese la base del triángulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = double.Parse(Console.ReadLine());

                    double area = (baseTriangulo * alturaTriangulo) / 2;

                    Console.WriteLine("Triángulo " + (i + 1) + ": Base = " + baseTriangulo + ", Altura = " + alturaTriangulo + ", Área = " + area);

                    if (area > 12)
                    {
                        valorLimite++;
                    }
                }

                Console.WriteLine($"Cantidad de triángulos con área mayor a 12 unidades cuadradas:  { valorLimite } ");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
