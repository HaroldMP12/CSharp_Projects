namespace CalcularSueldoEmpleados.Empleados
{
    /// <summary>
    /// Este objeto calcula el sueldo de los empleados e
    /// informa el importe que gasta la empresa en sueldos al personal.
    /// </summary>
    public class CalcularIngresosEmpleados
    {
        /// <summary>
        /// Calcula el sueldo de los empleados e informa los sueldos del personal que invierte la empresa.
        /// </summary>
        public void CalcularIngresos()
        {
            //Declarando variables

            int sueldos100a300 = 0;
            int sueldosMayor300 = 0;
            int totalSueldos = 0;
            int i = 1;
            int cantidad = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor ingrese la cantidad de empleados a evaluar: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!int.TryParse(linea, out cantidad))
                {
                    Console.WriteLine($"El valor es inválido. {linea}");
                    return;
                }

                cantidad = Convert.ToInt32(linea);

                while (i <= cantidad)
                {
                    Console.WriteLine($"Ingrese el sueldo del empleado: {i} ");
                    int sueldo = int.Parse(Console.ReadLine());

                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        sueldos100a300++;
                    }
                    else if (sueldo > 300 && sueldo <= 500)
                    {
                        sueldosMayor300++;
                    }

                    totalSueldos += sueldo;
                    i++;
                }

                Console.WriteLine($"Empleados con sueldos entre $100 y $300: {sueldos100a300}");
                Console.WriteLine($"Empleados con sueldos mayores a $300: {sueldosMayor300}");
                Console.WriteLine($"Total gastado en sueldos: ${totalSueldos}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en el programa");
            }
        }
    }
}
