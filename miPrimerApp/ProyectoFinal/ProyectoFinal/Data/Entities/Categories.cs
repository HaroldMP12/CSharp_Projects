using ProyectoFinal.Data.Base;

namespace ProyectoFinal.Data.Entities
{
    public class Categories : BaseEntity
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
    }
}
