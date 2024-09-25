namespace ProyectoFinal.Data.Models.Suppliers
{
    public class SuppliersRemoveModel
    {
        public int supplierid { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
