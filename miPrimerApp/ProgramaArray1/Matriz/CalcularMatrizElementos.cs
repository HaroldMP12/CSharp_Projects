namespace ProgramaArray1.Matriz
{
    public class CalcularMatrizElementos
    {
        public void CalcularMatriz()
        {
            int cantidadElementos = 20;
            int[] matriz = new int[cantidadElementos];
            string linea = string.Empty;

            try
            {
                for (int i = 0; i < cantidadElementos; i++)
                {
                    matriz[i] = i * 5;
                }

                Console.WriteLine("{0}{1,8}", "Indice", "Valor");

                for (int i = 0; i < matriz.Length; i++)
                {
                    Console.WriteLine("{0,5}{1,8}", i , matriz[i]);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message} mostrando la matriz");
            }
        }
    }
}
