namespace Ejercicio1POO.Plano
{
    public class Punto
    {
        private int x, y;

        public void Inicializar()
        {
            string linea;
            Console.WriteLine("Ingrese coordenada x :");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.WriteLine("Ingrese coordenada y :");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el primer cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Se encuentra en el segundo cuadrante.");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Se encuentra en el tercer cuadrante.");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("Se encuentra en el cuarto cuadrante.");
                        }
                        else
                        {
                            Console.WriteLine("El punto no está en un cuadrante.");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            punto1.Inicializar();
            punto1.ImprimirCuadrante();
        }
    }
}
