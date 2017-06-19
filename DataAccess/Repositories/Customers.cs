using DataAccess.IRepositories;
using DataAccess.Repositories;
using DataModels;
using DataModels.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class Customers:ICustomers
    {
        Repository<Customer> _Repository = new Repository<Customer>(new StoreContext());

        public Customer GetCustomerByID(int ID)
        {
            return _Repository.get(ID);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _Repository.GetAll();
        }

        public int InsertCustomer(Customer CustomerEntity)
        {
            return _Repository.Insert(CustomerEntity);
        }

        public int RemoveCustomer(Customer CustomerEntity)
        {
            return _Repository.Remove(CustomerEntity);
        }

        public int updateCustomer(Customer CustomerEntity)
        {
            return _Repository.Update(CustomerEntity);
        }

    }
}
