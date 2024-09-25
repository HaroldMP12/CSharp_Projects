using ProyectoFinal.Data.Models.Customers;

namespace ProyectoFinal.Data.Interfaces
{
    public interface ICustomersDb
    {
        List<CustomersModel> GetCustomers();
        CustomersModel GetCustomers(int customersId);
        void SaveCustomers(CustomersAddModel customersAdd);
        void UpdateCustomers(CustomersUpdateModel customersUpdate);
        void RemoveCustomers(CustomersRemoveModel customersRemove);
    }
}
