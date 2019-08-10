using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MovieApplication.Models;
using MovieApplication.ViewModels;

namespace MovieApplication.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _Context;

        public CustomerController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }             
       
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if(customer.Id == 0)
              _Context.Customers.Add(customer);
            else
            {
                var CustInDb = _Context.Customers.Single(c => c.Id == customer.Id);

                CustInDb.Id = customer.Id;
                CustInDb.Name = customer.Name;
                CustInDb.City = customer.City;
                CustInDb.MovieName = customer.MovieName;
            }

            _Context.SaveChanges();

            return RedirectToAction("ShowCustomer", "Customer");
        }
        public ActionResult Index(int Id)
        {
            var Cust = _Context.Customers.Single(emp => emp.Id == Id);
            return View(Cust);
        }

        public ActionResult ShowCustomer()
        {
            var Customer = _Context.Customers.ToList();
            return View(Customer);
        }

        public ActionResult ViewForm()
        {
            var PaymentModes = _Context.PaymentModes.ToList();
            var ViewModel = new CustomerPaymentModeViewModel
            {
               paymentMode = PaymentModes
            };
            return View(ViewModel);            
        }

        public ActionResult Edit(int Id)
        {
            var customer = _Context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();


            var ViewModel = new CustomerPaymentModeViewModel
            {
                customer = customer,
                paymentMode = _Context.PaymentModes.ToList()
            };
            return View("ViewForm", ViewModel);
        }
    }
}