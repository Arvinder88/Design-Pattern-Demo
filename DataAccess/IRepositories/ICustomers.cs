using DataModels.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
   public interface ICustomers
    {
        Customer GetCustomerByID(int ID);
        IEnumerable<Customer> GetAllCustomer();
        int InsertCustomer(Customer CustomerEntity);
        int RemoveCustomer(Customer CustomerEntity);
        int updateCustomer(Customer CustomerEntity);

    }
}
