namespace ProgramaArray1.PracticaArray2
{
    public class CalcularIgualdadMatrices
    {
        public void SimetriaMatriz()

        {
            try

            {
                Console.WriteLine("Ingrese el número de filas y columnas de la matriz:");
                int fil = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (fil != col)
                {
                    Console.WriteLine("La matriz debe ser cuadrada para verificar si es simétrica.");
                    return;
                }

                int[,] matriz = new int[fil, col];

                Console.WriteLine("Ingrese los elementos de la matriz:");
                for (int i = 0; i < fil; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write($"Matriz[{i + 1},{j + 1}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                bool esSimetrica = true;
                for (int i = 0; i < fil; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (matriz[i, j] != matriz[j, i])
                        {
                            esSimetrica = false;
                            break;
                        }
                    }
                    if (!esSimetrica)
                    {
                        break;
                    }
                }

                if (esSimetrica)
                {
                    Console.WriteLine("La matriz es simétrica.");
                }
                else
                {
                    Console.WriteLine("La matriz no es simétrica.");
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} mostrando la matriz");
            }
        }
    }
}
