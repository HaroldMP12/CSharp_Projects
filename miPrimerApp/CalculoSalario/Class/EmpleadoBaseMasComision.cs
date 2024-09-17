namespace CalculoSalario.Class
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }
        public override decimal Calcular() => (this.TarifaComision * this.VentasBrutas) + this.SalarioBase;
    }
}
