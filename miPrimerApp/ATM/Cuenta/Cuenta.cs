namespace ATM.Cuenta
{
    public class Cuenta
    {
        private decimal saldo;

        public Cuenta(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }
        public void Acredita (decimal monto)
        {
            Saldo = Saldo + monto;
        }
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }
    }
}
