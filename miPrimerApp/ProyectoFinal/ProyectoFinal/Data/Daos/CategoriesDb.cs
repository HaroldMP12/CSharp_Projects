using ProyectoFinal.Data.Context;
using ProyectoFinal.Data.Entities;
using ProyectoFinal.Data.Exceptions;
using ProyectoFinal.Data.Interfaces;
using ProyectoFinal.Data.Models.Categories;
using System.Collections.Generic;

namespace ProyectoFinal.Data.Daos
{
    public class CategoriesDb : ICategoriesDb
    {
        private readonly ShopContext shopContext;
        private readonly ILogger<CategoriesDb> logger;

        public CategoriesDb(ShopContext shopContext,
                             ILogger<CategoriesDb> logger)
        {
            this.shopContext = shopContext;
            this.logger = logger;
        }
        public List<CategoriesAddModel> GetCategories()
        {
            List<CategoriesAddModel> categories = new List<CategoriesAddModel>();
            try
            {
                categories = (from catgo in this.shopContext.Categories
                              where catgo.deleted == false
                              orderby catgo.creation_date descending
                              select new CategoriesAddModel()
                              {
                                  categoryid = catgo.categoryid,
                                  categoryname = catgo.categoryname,
                                  description = catgo.description,
                                  creation_date = catgo.creation_date,
                                  creation_user = catgo.creation_user  
                              }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obteniendo los departamentos {ex}", ex.ToString());
            }
            return categories;
        }

        public CategoriesAddModel GetCategoriesById(int categoriesId)
        {
            CategoriesAddModel categoriesResult = new CategoriesAddModel();
            try
            {
                var categories = this.shopContext.Categories.Find(categoriesId);

                if (categories is null)
                    throw new CategoriesException("Las categorias no se encuentran registradas.");

                categoriesResult.categoryid = categories.categoryid;
                categoriesResult.categoryname = categories.categoryname;    
                categoriesResult.description = categories.description;  
                categoriesResult.creation_date = categories.creation_date;  
                categoriesResult.creation_user = categories.creation_user;  
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo el departamento", ex.ToString());
            }
            return categoriesResult;
        }

        public void RemoveCategories(CategoriesRemoveModel categoriesRemove)
        {
            try
            {
                if (categoriesRemove is null)
                    throw new CategoriesException("El objeto categorias no puede ser nulo.");

                var categorias = this.shopContext.Categories.Find(categoriesRemove.categoryid);

                if (categorias is null)
                    throw new CategoriesException("La categoria no se encuentra registrada.");

                categorias.deleted = true;
                categorias.delete_date = categoriesRemove.delete_date;
                categorias.delete_user = categoriesRemove.delete_user;  

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error removiendo el departamento", ex.ToString());
            }
        }

        public void SaveCategories(CategoriesAddModel categoriesAdd)
        {
            try
            {
                if (categoriesAdd is null)
                    throw new CategoriesException("El objeto categorias no puede ser nulo.");

                if (this.shopContext.Categories.Any(catego => catego.categoryname == categoriesAdd.categoryname))
                    throw new CategoriesException("El objeto categorias no puede ser nulo.");

                Categories categories = new Categories()
                {
                    categoryname = categoriesAdd.categoryname,
                    description = categoriesAdd.description,
                    creation_date = categoriesAdd.creation_date,
                    creation_user = categoriesAdd.creation_user,
                };
                this.shopContext.Categories.Add(categories);
                this.shopContext.SaveChanges();  

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error guardando el departamento", ex.ToString());
            }
        }

        public void UpdateCategories(CategoriesUpdateModel categoriesUpdate)
        {
            try
            {
                if (categoriesUpdate is null)
                    throw new CategoriesException("El objeto categorias no puede ser nulo.");

                Categories categorias = this.shopContext.Categories.Find(categoriesUpdate.categoryid);

                if (categorias is null)
                    throw new CategoriesException("La categoria no se encuentra registrada.");

                categorias.categoryname = categoriesUpdate.categoryname;    
                categorias.description = categoriesUpdate.description;  
                categorias.modify_date = categoriesUpdate.modify_date;  
                categorias.modify_user = categoriesUpdate.modify_user;

                this.shopContext.Categories.Update(categorias);
                this.shopContext.SaveChanges();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error actualizando el departamento", ex.ToString());
            }
        }
    }
}
