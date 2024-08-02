namespace CalcularSueldo.PrecioArticulo
{
    /// <summary>
    /// Calcular el precio del articulo y lo que debe abonar un cliente.
    /// </summary>
    public class CalcularPrecioArticulo
    {
        /// <summary>
        /// Calcular precio del articulo del cliente.
        /// </summary>
        public void Calcular()
        {
            //Declarando variables

            int precioArticulo = 0;
            int cantidadDineroCliente = 0;
            int abonoArticulo = 0;
            string linea = string.Empty;

            //Solicitar al usuario por teclado

            try
            {

                Console.WriteLine("Por favor ingrese el precio del artículo: ");
                linea = string.Empty;

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out precioArticulo))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }
                precioArticulo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor ingrese la cantidad disponible: ");
                linea = string.Empty;

                if(string.IsNullOrEmpty(linea))
                {
                    Console.Write("El valor es requerido");
                    return;
                }

                if (!int.TryParse(linea, out cantidadDineroCliente))
                {
                    Console.WriteLine();
                    return;
                }

                cantidadDineroCliente = Convert.ToInt32(Console.ReadLine());

                abonoArticulo = (precioArticulo - cantidadDineroCliente);

                Console.WriteLine($"La cantidad para abonar al artículo es de: ${abonoArticulo} DOP");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} ejecutando el programa.");
            }
        }
    }
}
