namespace ReferenciaArreglo.ArregloPorReferencia
{
    public class PruebaReferenciaArreglo
    {
        public static void Main(string[] args)
        {
            int[] primerArreglo = { 1, 2, 3 };

            int[] copiaPrimerArreglo = primerArreglo;

            Console.WriteLine(
                "Prueba: paso de la referencia a primerArreglo por valor");

            Console.Write("\nContenido de primerArreglo " +
                " antes de llamar a PrimerDoble:\n\t");

            for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0}", primerArreglo[i]);

            PrimerDoble(primerArreglo);

            Console.Write("\n\nContenido de primerArreglo despues de " +
                " llamar a PrimerDoble\n\t");

            for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0}", primerArreglo[i]);

            if (primerArreglo == copiaPrimerArreglo)
                Console.WriteLine(
                    "\n\nLas referencias son al mismo arreglo");
            else
                Console.WriteLine(
                    "\n\nLas referencias son a distintos arreglos");

            int[] segundoArreglo = { 1, 2, 3 };

            int[] copiaSegundoArreglo = segundoArreglo;

            Console.WriteLine("\nPrueba: paso de la referencia a segundoArreglo" +
                " por referencia");

            Console.Write("\nContenido de segundoArreglo" +
                " antes de llamar a SegundoDoble:\n\t");

            for(int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0}", segundoArreglo[i]);

            SegundoDoble(ref segundoArreglo);

            Console.Write("\n\nContenido de segundoArreglo" +
                "antes de llamar a SegundoDoble:\n\t");

            for (int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0}", segundoArreglo[i]);

            if (segundoArreglo == copiaSegundoArreglo)
                Console.WriteLine(
                    "\n\nLas referencias son al mismo arreglo");
            else
                Console.WriteLine(
                    "\n\nLas referencias son a distintos arrreglos");
        }
        public static void PrimerDoble(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;

            arreglo = new int[] {11, 12, 13};
        }
        public static void SegundoDoble(ref int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;

            arreglo = new int[] {11, 12, 13};
        }
    }
}
