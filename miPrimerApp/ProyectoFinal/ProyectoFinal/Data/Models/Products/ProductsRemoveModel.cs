﻿namespace ProyectoFinal.Data.Models.Products
{
    public class ProductsRemoveModel
    {
        public int productid { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}