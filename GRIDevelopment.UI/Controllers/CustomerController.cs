using System;
using System.Linq;
using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.Mpper;
using Microsoft.AspNetCore.Mvc;

namespace GRIDevelopment.UI.Controllers
{
    public class CustomerController : Controller
    {
        
            private readonly ICustomerService _customerService;
            public CustomerController(ICustomerService customerService, DomainCustomerMapper mapper)
            {
                _customerService = customerService;
            }

        public IActionResult Index(string searchString)
        {
            var customers = from p in _customerService.GetAllCustomers() select p;



            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.customer_name!.Contains(searchString));
            }



            else { customers = customers.OrderBy(s => s.customer_name); }
            //_productService.GetAllProducts();
            return View(customers);





        }

        [HttpGet]
        public IActionResult AddEditCustomer(int? id)
        {
            if (id == null)
                return View();
            else
            {
                var supplier = _customerService.GetCustomerById(id.Value);
                return View(supplier);
            }
        }

        [HttpPost]
        public IActionResult AddEditCustomer(CustomerDTO customer)
        {
            if (!ModelState.IsValid)
                return View();

            if (customer.Id > 0)
            {
                _customerService.UpdatePost(customer);
            }
            else
            {
                _customerService.AddCustomer(customer);
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            _customerService.RemovePost(id);

            return RedirectToAction("Index");
        }
    }
    
}
