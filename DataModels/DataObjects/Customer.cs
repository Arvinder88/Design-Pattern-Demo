using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModels.DataObjects
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
          [Required(ErrorMessage = "Please Enter the Mobile No")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public  string UserName { get; set; }
       // public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter the Mobile No")]
        [MaxLength(14)]
        public string Mobile { get; set; }
        public string SecondaryMobile { get; set; }
        public string  Address { get; set; }
      // public int StoreID { get; set; }
    }
}
