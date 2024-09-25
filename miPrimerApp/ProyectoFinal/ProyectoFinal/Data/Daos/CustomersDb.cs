using ProyectoFinal.Data.Context;
using ProyectoFinal.Data.Interfaces;
using ProyectoFinal.Data.Models.Customers;

namespace ProyectoFinal.Data.Daos
{
    public class CustomersDb : ICustomersDb
    {
        private readonly ShopContext context;
        public CustomersDb(ShopContext context)
        {
            this.context = context;
        }
        public List<CustomersModel> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public CustomersModel GetCustomers(int customersId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomers(CustomersRemoveModel customerAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveCustomers(CustomersAddModel customersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomers(CustomersUpdateModel customersAdd)
        {
            throw new NotImplementedException();
        }
    }
}
