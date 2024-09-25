using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Data.Interfaces;
using ProyectoFinal.Data.Models.Categories;

namespace ProyectoFinal.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesDb categoriesDb;

        public CategoriesController(ICategoriesDb categoriesDb)
        {
            this.categoriesDb = categoriesDb;
        }
        public ActionResult Index()
        {
            var categories = this.categoriesDb.GetCategories();
            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var categories = this.categoriesDb.GetCategoriesById(id);
            return View(categories);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesAddModel categoriesAdd)
        {
            try
            {
                categoriesAdd.creation_date = DateTime.Now;
                categoriesAdd.creation_user = 2;
                this.categoriesDb.SaveCategories(categoriesAdd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var categories = this.categoriesDb.GetCategoriesById(id);
            return View(categories);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesUpdateModel categoriesUpdate)
        {
            try
            {
                categoriesUpdate.modify_date = DateTime.Now;
                categoriesUpdate.modify_user = 2;
                this.categoriesDb.UpdateCategories(categoriesUpdate);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
