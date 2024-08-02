namespace CalcularSueldo.Calcular
{
    /// <summary>
    /// Este objeto es para calcular los sueldos de los operadores.
    /// </summary>
    public class CalcularSueldoOperario
    {

        ///// <summary>
        ///// Calcular el sueldo de los operadores
        ///// </summary>
        ///// <param name="horasTrabajadas">Las horas trabajadas del empleado</param>
        ///// <param name="costoHora">El costo por hora definido por RRHH</param>
        //public void Calcular(int horasTrabajadas, int costoHora)
        //{
        //    //Declaramos las variables.
        //}

        public void CalcularSueldo()
        {
            //Declaramos las variables.

            int horasTrabajadas = 0;
            int costoHora = 0;
            decimal sueldo = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor ingrese las horas trabajadas: ");
                linea = Console.ReadLine();
                if (!int.TryParse(linea, out horasTrabajadas))
                {
                    Console.WriteLine($"Horas trabajadas inválidas: {linea}, favor de ingresar valores correctos.");
                    return;
                }
                
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor ingrese el costo de las horas trabajadas: ");
                costoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = (horasTrabajadas * costoHora);

                Console.WriteLine($"El sueldo es: {sueldo} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} durante la operación. :(");
            }

        }

    }
}
