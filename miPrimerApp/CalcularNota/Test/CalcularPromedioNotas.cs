namespace CalcularNota.Test
{
    public class CalcularPromedioNotas
    {
        public void CalcularNotas()
        {

            //Declarando variables

            decimal TotalPreguntas = 0;
            decimal TotalRespuestas = 0;
            decimal PorcentajeAciertos = 0;
            string linea = string.Empty;

            try
            {
                Console.WriteLine("Por favor ingrese el número total de preguntas: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!decimal.TryParse(linea, out TotalPreguntas))
                {
                    Console.WriteLine("El valor es inválido.");
                    return;
                }
                else
                {
                    TotalPreguntas = Convert.ToInt32(linea);
                }

                Console.WriteLine("Por favor ingrese el número de respuestas correctas: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El valor es requerido.");
                    return;
                }

                if (!decimal.TryParse(linea, out TotalRespuestas))
                {
                    Console.WriteLine("El valor es inválido.");
                    return;
                }
                else
                {
                    TotalRespuestas = Convert.ToInt32(linea);
                }

                PorcentajeAciertos = (TotalRespuestas / TotalPreguntas) * 100;

                if (PorcentajeAciertos >= 90)
                {
                    Console.WriteLine($"El postulante obtuvo un Nivel Máximo con: {PorcentajeAciertos} %");
                }
                else if ((PorcentajeAciertos >= 75) && (PorcentajeAciertos <= 90))
                {
                    Console.WriteLine($"El postulante obtuvo un Nivel Medio con: {PorcentajeAciertos} %");
                }
                else if ((PorcentajeAciertos >= 50) && (PorcentajeAciertos <= 75))
                {
                    Console.WriteLine($"El postulante obtuvo un Nivel Regular con: {PorcentajeAciertos} %");
                }
                else
                {
                    Console.WriteLine("Fuera de nivel.");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} en la ejecución del programa");
            }
        }
    }
}
