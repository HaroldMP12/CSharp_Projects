using CasoEstudio1.JuegoCartas;

namespace CasoEstudio1.Parte2
{
    public class PaqueteDeCartas
    {
        private Carta[] paquete;
        private int cartaActual;
        private const int NUMERO_DE_CARTAS = 52;
        private Random numerosAleatorios;

        public PaqueteDeCartas()
        {
            string[] caras = {"As", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
            "Siete", "Ocho", "Nueve", "Diez", "Joto", "Quina", "Rey"};

            string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

            paquete = new Carta[NUMERO_DE_CARTAS];
            cartaActual = 0;
            numerosAleatorios = new Random();

            for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
                paquete[cuenta] =
                    new Carta(caras[cuenta % 13], palos[cuenta / 13]);
        }
        public void Barajar()
        {
            cartaActual = 0;
            for(int primera = 0; primera < paquete.Length; primera++)
            {
                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);
                Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
            }
        }
        public Carta RepartirCarta()
        {
            if (cartaActual < paquete.Length)
                return paquete[cartaActual++];
            else
                return null;
        }
    }
}
