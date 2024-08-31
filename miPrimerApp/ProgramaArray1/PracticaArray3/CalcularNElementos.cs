namespace ProgramaArray1.PracticaArray3
{ 
    public class CalcularNElementos
    {
        public void CalcularValoresElementos()
        {
            Console.WriteLine("Ingrese la cantidad de números que desea introducir:");
            int N;

            // Leer y validar la cantidad de números
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }

            int[] numbers = new int[N];

            // Solicitar N números al usuario
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            }

            // Determinar el menor valor
            int minValue = numbers[0];
            for (int i = 1; i < N; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            // Verificar si algún valor se repite
            bool hasDuplicates = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        hasDuplicates = true;
                        break;
                    }
                }
                if (hasDuplicates)
                {
                    break;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"El menor valor ingresado es: {minValue}");
            Console.WriteLine(hasDuplicates ? "Hay valores que se repiten." : "No hay valores que se repiten.");
        }
    }
}
