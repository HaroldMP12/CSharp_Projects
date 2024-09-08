namespace ATM.Cuenta
{
    public class PruebaCuenta
    {
        public static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta(50.00M);
            Cuenta cuenta2 = new Cuenta(-7.53M);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);

            decimal montoDeposito;

            Console.WriteLine("Escriba el monto a depositar para la cuenta1: ");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("se sumó {0:C} al saldo de cuenta1\n", montoDeposito);
            cuenta1.Acredita(montoDeposito);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);

            Console.WriteLine("Escribe la cantidad a depositar para la cantidad2: ");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Se sumó {0:C} al saldo de la cuenta2\n", montoDeposito);

            cuenta2.Acredita(montoDeposito);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.Saldo);
        }
    }
}
