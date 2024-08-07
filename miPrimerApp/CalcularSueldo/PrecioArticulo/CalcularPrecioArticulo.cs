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
        public void CalcularArticulo()
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
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine($"El valor es requerido: {  linea  }");
                    return;
                }

                if (!int.TryParse(linea, out precioArticulo))
                {
                    Console.WriteLine($"El valor es inválido: {linea}");
                    return;
                }
                precioArticulo = Convert.ToInt32(linea);

                Console.WriteLine("Por favor ingrese la cantidad disponible del cliente: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.Write($"El valor es requerido: {  linea }");
                    return;
                }

                if (!int.TryParse(linea, out cantidadDineroCliente))
                {
                    Console.WriteLine($"El valor es inválido: { linea }");
                    return;
                }

                cantidadDineroCliente = Convert.ToInt32(linea);

                abonoArticulo = (precioArticulo - cantidadDineroCliente);

                Console.WriteLine($"La cantidad que el cliente debe abonar al artículo es: ${abonoArticulo} DOP");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} ejecutando el programa.");
            }
        }
    }
}
