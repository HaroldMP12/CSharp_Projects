namespace CalculoSalario.Class
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }
        public override decimal Calcular() => this.SalarioSemanal;
    }
}
