using DataAccess;
using DataAccess.Repositories;
using DataModels.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMangement.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult AddCustomer()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer Customer)
        {
            Customers objCustomer = new Customers();
           // Customer.CreateDate = GlobalFunctions.DateTimeNow();
            objCustomer.InsertCustomer(Customer);
            return RedirectToAction("AddCustomer");
        }

        [HttpGet]
        [Authorize]
        public ActionResult CustomerDetails()
        {
            Customers objCustomer = new Customers();
            var proList = objCustomer.GetAllCustomer();
            return View(proList);
        }

        [HttpGet]
        public ActionResult RemoveCustomer(int CustomerId)
        {
            Customers objCustomer = new Customers();
            Customer Customer = new Customer();
            Customer = objCustomer.GetCustomerByID(CustomerId);
            objCustomer.RemoveCustomer(Customer);
            return RedirectToAction("AddCustomer");
        }

        [HttpGet]
        [Authorize]
        public ActionResult UpdateCustomer(int CustomerId)
        {
            // TempUnitTable();
            Customers objCustomer = new Customers();
            Customer Customer = new Customer();
            Customer = objCustomer.GetCustomerByID(CustomerId);

            return View(Customer);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer Customer)
        {
            Customers objCustomer = new Customers();
            Customer customer = new Customer();
            customer = objCustomer.GetCustomerByID(Customer.CustomerID);
            customer.FirstName = Customer.FirstName;
            customer.LastName = Customer.LastName;
            customer.Mobile = Customer.Mobile;
            customer.SecondaryMobile = Customer.SecondaryMobile;
            customer.Address = Customer.Address;
            // Customer.CreateDate = GlobalFunctions.DateTimeNow();

            objCustomer.updateCustomer(customer);
            return RedirectToAction("CustomerDetails");
        }
    }
}