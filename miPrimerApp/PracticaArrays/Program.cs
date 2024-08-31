using System;

namespace PracticaArrays
{
    internal class Program
    {
        /*private static int[] sueldos; *///Esta variable global puede ser accedida de cualquier parte de la clase.
        private static float[] alturas;
        private static float promedio = 0;
        static void Main(string[] args)
        {
            //var valores = getCount();
            //CapturarSueldos();
            //ImprimirSueldos();
            CapturarAlturas();
            CalcularMayorMenor();

        }

        #region Ejemplo Arrays con los días de la semana
        //

        //string[] dayOfWeek = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        //var count = dayOfWeek.Length;

        //    for (int i = 0; i<dayOfWeek.Length; i++)
        //    {
        //        dayOfWeek[0] = "Domingo";
        //        Console.WriteLine($"Estamos en el día: " + dayOfWeek[i]);
        //    }
        //    return count;

        #endregion

        #region "Primer ejemplo de los ejercicios"
        //static void CapturarSueldos() //Variables locales solo pertenecen al metodo que se esta trabajando.
        //{
        //    int cantidadElementos = 5;
        //    sueldos = new int[cantidadElementos];
        //    string linea = string.Empty;

        //    for (int i = 0; i < cantidadElementos; i++)
        //    {
        //        Console.WriteLine($"Ingrese el sueldo: {i} ");
        //        linea = Console.ReadLine();
        //        sueldos[i] = Convert.ToInt32(linea);
        //    }

        //}
        //static void ImprimirSueldos()
        //{
        //    Console.WriteLine("{0}{1,8}", "Indices", "Sueldos");

        //    //for (int i = 0; i < sueldos.Length; i++)
        //    //{
        //    //    int sueldo = sueldos[i];
        //    //    Console.WriteLine("{0,4}{1,8}", i, sueldos[i]);
        //    //}

        //    int i = 0;
        //    foreach (int sueldo in sueldos)
        //    {
        //        Console.WriteLine("{0,4}{1,8}", i, sueldo);
        //        i++;
        //    }
        //}

        #endregion

        #region "Ejemplo de alturas de personas"

        static void CapturarAlturas()
        {
            try
            {
                alturas = new float[5];
                float acumulador = 0;

                for (int i = 0; i < alturas.Length; i++)
                {
                    Console.WriteLine($"Ingrese la altura de la persona: {i}");
                    string linea = Console.ReadLine();

                    if (string.IsNullOrEmpty( linea ))
                    {
                        Console.WriteLine("El valor es requerido.");
                        return;
                    }

                    if (float.TryParse(linea, out float altura))
                    {
                        alturas[i] = altura;
                        acumulador+= alturas[i];
                    }
                    else
                        Console.WriteLine("Altura inválida.");
                        return;
                }

                promedio = (acumulador / alturas.Length);

                Console.WriteLine($"El promedio de las alturas de las personas es: { promedio }");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
        #endregion

        static void CalcularMayorMenor()
        {
            int mayor = 0;
            int menor = 0;

            try
            {
                for (int i = 0; i < alturas.Length; i++)
                {
                    float altura = alturas[i];

                    if (altura > promedio)
                    {
                        mayor++;
                    }
                    else
                    {
                        menor++;
                    }
                }
                Console.WriteLine($"La cantidad de personas con alturas mayores son: { mayor } y las menores: { menor }");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } mostrando las alturas.");
            }
        }
    }

}
