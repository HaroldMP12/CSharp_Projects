namespace miPrimerApp.Operaciones
{
    public class Operacion
    {
        public void SumarNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.WriteLine("Por favor digite el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);

            Console.WriteLine($"El resultado es: {suma}");
            Console.ReadLine();
        }
        public void MultiplicarNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int multiplicar = 0;

            Console.WriteLine("Por favor digite el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            multiplicar = (num1 * num2);

            Console.WriteLine($"El resultado es: {multiplicar}");
            Console.ReadLine();
        }
    }
}
