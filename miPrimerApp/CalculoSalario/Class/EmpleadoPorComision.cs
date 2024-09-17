namespace CalculoSalario.Class
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }
        public override decimal Calcular() => this.TarifaComision * this.VentasBrutas;
    }
}
