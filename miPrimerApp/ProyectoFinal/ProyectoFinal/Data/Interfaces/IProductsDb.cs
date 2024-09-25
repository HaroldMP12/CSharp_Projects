using ProyectoFinal.Data.Models.Products;

namespace ProyectoFinal.Data.Interfaces
{
    public interface IProductsDb
    {
        List<ProductsModel> GetProducts();
        ProductsModel GetProducts(int productsId);
        void SaveProducts(ProductsAddModel productsAdd);
        void UpdateProducts(ProductsUpdateModel productsUpdate);
        void RemoveProducts(ProductsRemoveModel productsRemove);
    }
}
