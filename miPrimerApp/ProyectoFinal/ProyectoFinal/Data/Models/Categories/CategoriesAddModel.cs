using ProyectoFinal.Data.Base;

namespace ProyectoFinal.Data.Models.Categories
{
    public class CategoriesAddModel
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
