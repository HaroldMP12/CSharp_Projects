using ProyectoFinal.Data.Context;
using ProyectoFinal.Data.Interfaces;
using ProyectoFinal.Data.Models.Products;

namespace ProyectoFinal.Data.Daos
{
    public class ProductsDb : IProductsDb
    {
        private readonly ShopContext context;
        public ProductsDb(ShopContext context)
        {
            this.context = context;
        }
        public List<ProductsModel> GetProducts()
        {
            throw new NotImplementedException();
        }

        public ProductsModel GetProducts(int productsId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProducts(ProductsRemoveModel productsAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveProducts(ProductsAddModel productsAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(ProductsUpdateModel productsAdd)
        {
            throw new NotImplementedException();
        }
    }
}
