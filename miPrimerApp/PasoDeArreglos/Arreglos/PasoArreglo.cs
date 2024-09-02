namespace PasoDeArreglos.Arreglos
{
    public class PasoArreglo
    {
        public static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            Console.WriteLine(
                "Efectos de pasar una referencia a todo un arreglo: \n" +
                " Los valores del arreglo original son: ");

            foreach (int valor in arreglo)
                Console.Write("   {0}", valor);

            ModificarArreglo(arreglo);
            Console.WriteLine("\n\nLos valores del arreglo modificado son: ");

            foreach (int valor in arreglo)
                Console.Write("   {0}", valor);

            Console.WriteLine(
                "\n\nEfectos de pasar el valor de un elemento del arreglo:\n" +
                " arreglo[3] antes de ModificarElemento: {0}", arreglo[3]);
            ModificarElemento(arreglo[3]);

            Console.WriteLine(
                "arreglo[3] despues de ModificarElemento: {0}", arreglo[3]);
        }
        public static void ModificarArreglo(int[] arreglo2)
        {
            for(int contador = 0; contador < arreglo2.Length; contador++)
                arreglo2[contador] *= 2;
        }
        public static void ModificarElemento(int elemento)
        {
            elemento *= 2;
            Console.WriteLine(
                "Valor del elemento en ModificarElemento: {0}", elemento);
        }
    }
}
