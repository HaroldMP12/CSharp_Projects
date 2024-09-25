using ProyectoFinal.Data.Models.Categories;

namespace ProyectoFinal.Data.Interfaces
{
    public interface ICategoriesDb
    {
        List<CategoriesAddModel>GetCategories();
        CategoriesAddModel GetCategoriesById(int categoriesId);
        void SaveCategories(CategoriesAddModel categoriesAdd);
        void UpdateCategories(CategoriesUpdateModel categoriesUpdate);
        void RemoveCategories(CategoriesRemoveModel categoriesRemove);
    }
}
