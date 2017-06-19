using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.DataObjects;

namespace DataModels
{
    public class StoreContext : DbContext
    {

        public StoreContext()
            : base("name=StoreCN")
        {

            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<Customer> DBCustomer { get; set; }
       
    }
}
