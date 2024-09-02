using CasoEstudio1.Parte2;
namespace CasoEstudio1.Parte3
{
    public class PruebaPaqueteCartas
    {
        public static void Main(string[] args)
        {
            PaqueteDeCartas miPaqueteDeCartas = new PaqueteDeCartas();
            miPaqueteDeCartas.Barajar();

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                    miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta(),
                    miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta());
            }
        }

    }
}
