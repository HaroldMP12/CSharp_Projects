namespace EjemplosResumenArrays.Ejemplos
{
    /// <summary>
    /// Este objeto crea un arreglo para luego imprimir los valores en pantalla
    /// </summary>
    public class CalcularValArray
    {
        /// <summary>
        /// Calcula y dibuja los valores de los indices del arreglo para mostrarlos por pantalla
        /// </summary>

        #region "Primer ejemplo del resumen"
        public void CalcularArray()
        {
            //Declaramos las variables del arreglo
            
            int[] arreglo;
            arreglo = new int[10];

            Console.WriteLine("{0}{1,8}", "Indice" , "Valor");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("{0,5}{1,8}", i, arreglo[i]);
            }
        }
        #endregion

        #region "Segundo ejemplo del resumen"
        //Inicializando un array mediante listas definidas por el usuario
        public void InicializadorArray()
        {
            int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37};

            Console.WriteLine("{0}{1,8}", "Indice", "Valor");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("{0,5}{1,8}", i , arreglo[i]);
            }

        }
        #endregion

        #region "Tercer ejemplo del resumen"
        public void CalcularValorAGuardarArray()
        {
            //Calculamos y capturamos el elemento para guardarlo en el arreglo

            const int LONGITUD_ARREGLO = 10; // Crea una constante con el nombre
            int [] arreglo = new int [LONGITUD_ARREGLO]; //Crea el arreglo 

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = 2 + 2 * i;
            }

            Console.WriteLine("{0}{1,8}", "Indice", "Valor");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("{0,5}{1,8}", i , arreglo[i]);
            }

        }
        #endregion

        #region "Cuarto ejemplo del resumen"
        public void SumaArray()
        {
            //Suma de los elementos en un array

            int[] arreglo = {87 ,68 ,94, 100, 83, 78, 85, 91, 76, 87};
            int total = 0;

            for (int i = 0; i < arreglo.Length; i++)
                total += arreglo[i]; 

            Console.WriteLine("Total de los elementos del arreglo: {0}", total);
        }
        #endregion

        #region "Quinto ejemplo del resumen"
        public void GraficoBarras()
        {
            //Distribuidor de calificaciones 

            int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1};
            Console.WriteLine("Distribuidor de calificaciones: ");

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine(" 100: ");
                }
                else
                {
                    Console.WriteLine(" {0:D2}-{1:D2}: ",
                    i * 10, i * 10 + 9);
                }
                for (int estrellas = 0; estrellas < arreglo[i]; estrellas++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region "Sexto ejemplo del resumen"
        public void TirarDado()
        {
            Random numerosAleatorios = new Random(); // Para generar los numeros aleatorios
            int[] frecuencia = new int[7];

            for (int tiro = 1; tiro <= 6000; tiro++)
            {
                ++frecuencia[numerosAleatorios.Next(1, 7)];
            }
            Console.WriteLine("{0}{1,15}", "Cara", "Frecuencia");

            for (int cara = 1; cara < frecuencia.Length; cara++)
            {
                Console.WriteLine( "{0,4}{1,15}", cara, frecuencia[cara]);
            }
        }
        #endregion

        #region "Septimo ejemplo del resumen"
        public void EncuestaEstudiantes()
        {
            //Encuesta a estudiantes sobre comida de la cafeteria estudiantil

            int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6,
            10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6,
            4, 8, 6, 8, 10};

            int[] frecuencia = new int[11];

            for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
            {
                ++frecuencia[respuestas[respuesta]];
            }
            Console.WriteLine("{0}{1,11}", "Calificacion", "Frecuencia");

            for (int calificacion = 0; calificacion < frecuencia.Length; calificacion++)
            {
                Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
            }
        }
        #endregion

        #region "Octavo ejemplo del resumen"
        public void ArregloForEach()
        {
            int[] arreglo = {87,68,94,100,83,78,85,91,76,87 };
            int total = 0;

            foreach (int numero in arreglo)
                total += numero;

            Console.WriteLine("Total de elementos en el arreglo: {0}", total);
        }
        #endregion
    }
}
