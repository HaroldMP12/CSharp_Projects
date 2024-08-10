namespace CalcularNotas.Impuestos
{
    /// <summary>
    /// Programa que calcula si el sueldo de una persona es mayor a 3000 debe abonar dinero
    /// </summary>
    public class CalcularSueldo
    {
        /// <summary>
        /// Calcula el sueldo de la persona y si es mayor de 3000 abona dinero
        /// </summary>
        public void CalcularAbonoImpuesto()
        {
            //Declarar variables

            int sueldo = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor digite su sueldo: ");
                linea = Console.ReadLine();

                if(string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El sueldo es requerido.");
                    return;
                }

                if (!int.TryParse(linea , out sueldo))
                {
                    Console.WriteLine("El sueldo es inválido.");
                    return;
                }
                else
                {
                    sueldo = Convert.ToInt32(linea);
                }

                if (sueldo > 3000)
                {
                    Console.WriteLine("Esta persona debe abonar impuestos.");
                }
                else
                {
                    Console.WriteLine("Esta persona no debe abonar impuestos.");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa.");
            }
        }
    }
}
