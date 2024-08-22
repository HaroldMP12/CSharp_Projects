namespace CalcularLotePiezas.Piezas
{
    /// <summary>
    /// Estre objeto calcula las piezas para procesar de un lote para identificar las aptas y no aptas
    /// </summary>
    public class CalcularPiezasProcesar
    {
        /// <summary>
        /// Calcula las piezas que estan aptas y las que no estan aptas por lote
        /// </summary>
        public void CalcularLotePiezas()
        {
            //Declarando las variables.

            int cantidad = 0;
            int i = 1;
 
            double largoBaja = 1.20;
            double largoAlta = 1.30;
            float largo = 0;
            int cantPiezas = 0;
            string linea = string.Empty;
            string piezasAptas = string.Empty;
            string piezasNoAptas = string.Empty;
            

            try
            {
                Console.WriteLine("Por favor ingresar la cantidad de piezas a procesar: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if(!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. { linea } ");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                while (i <= cantidad)
                {
                    Console.WriteLine($"Ingrese la medida de la pieza {i}: ");
                    largo = float.Parse(Console.ReadLine());

                    if (largo >= largoBaja && largo <= largoAlta)
                    {
                        cantPiezas++;
                        piezasAptas += largo + " ";
                    }
                    else
                    {
                        piezasNoAptas += largo + " ";
                    }
                    i++;
                }

                Console.WriteLine($"La cantidad de piezas a procesar: { cantidad } y las piezas aptas: { cantPiezas }");
                Console.WriteLine($"Las piezas aptas fueron: { piezasAptas } y las no aptas: { piezasNoAptas }");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } en la ejecución del programa.");
            }
        }
    }
}
