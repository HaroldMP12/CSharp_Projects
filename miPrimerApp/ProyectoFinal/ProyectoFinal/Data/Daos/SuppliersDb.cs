using ProyectoFinal.Data.Context;
using ProyectoFinal.Data.Interfaces;
using ProyectoFinal.Data.Models.Suppliers;

namespace ProyectoFinal.Data.Daos
{
    public class SuppliersDb : ISuppliersDb
    {
        private readonly ShopContext context;
        public SuppliersDb(ShopContext context)
        {
            this.context = context;
        }
        public List<SuppliersModel> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public SuppliersModel GetSuppliers(int suppliersId)
        {
            throw new NotImplementedException();
        }

        public void RemoveSuppliers(SuppliersRemoveModel suppliersAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveSuppliers(SuppliersAddModel suppliersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateSuppliers(SuppliersUpdateModel suppliersAdd)
        {
            throw new NotImplementedException();
        }
    }
}
