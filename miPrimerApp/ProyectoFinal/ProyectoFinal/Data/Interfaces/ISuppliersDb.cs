using ProyectoFinal.Data.Models.Suppliers;

namespace ProyectoFinal.Data.Interfaces
{
    public interface ISuppliersDb
    {
        List<SuppliersModel> GetSuppliers();
        SuppliersModel GetSuppliers(int suppliersId);
        void SaveSuppliers(SuppliersAddModel suppliersAdd);
        void UpdateSuppliers(SuppliersUpdateModel suppliersUpdate);
        void RemoveSuppliers(SuppliersRemoveModel suppliersRemove);
    }
}
