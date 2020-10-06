using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        public ActionResult New()
        {
            IEnumerable<MembershipType> memberShipTypes = _context.MembershipTypes.ToList();
            NewCustomerViewModels viewModel = new NewCustomerViewModels
            {
                MembershipTypes = memberShipTypes
            };

            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            List<Customer> customers = _context.Customers.Include(c => c.MembershipType).ToList();

            ViewBag.Customers = customers;

            return View();
        }

        public ActionResult Details(int id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            ViewBag.Data = customer;

            return View();
        }


    }
}