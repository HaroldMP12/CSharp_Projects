namespace CalculoSalario.Class
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal Sueldo { get; set; }
        public int Horas { get; set; }
        public override decimal Calcular()
        {

            decimal valorPagar = 0;
            decimal porcentaje = 1.5m;
            int horaPorDefault = 40;

            if (this.Horas <= horaPorDefault)
                valorPagar = this.Sueldo * this.Horas;
            else if (this.Horas > horaPorDefault)
            {
                valorPagar = horaPorDefault * this.Sueldo + (this.Horas - horaPorDefault) * this.Sueldo * porcentaje;
            }
            return valorPagar;
        }
    }
}
