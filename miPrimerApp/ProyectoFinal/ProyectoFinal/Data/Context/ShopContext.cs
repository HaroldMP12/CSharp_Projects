using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data.Entities;

namespace ProyectoFinal.Data.Context
{
    public class ShopContext : DbContext
    {
        #region "Constructor"
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        #endregion

        #region "DbSets"
        public DbSet<Categories> Categories { get; set; }
        //public DbSet<Customers> Customers { get; set; }
        //public DbSet<Products> Products { get; set; }
        //public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la clave primaria de la tabla
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.categoryid); // La clave primaria
            });
        }
        #endregion

    }

}
