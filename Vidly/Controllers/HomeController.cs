using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer() {Name = "Ali Haider", Id = 1},
            new Customer() {Name = "Ali Murtuza", Id = 2}
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("home/user")]
        public ActionResult Users()
        {


            ViewBag.Users = customers;


            return View();


        }


        [Route("home/user/{Id}")]
        public ActionResult User(int Id)
        {
            if (Id > customers.Count || Id == 0)
            {
                return HttpNotFound();
            }

            UserViewModel userModel = new UserViewModel()
            {
                Name = customers[Id - 1].Name
            };

            ViewBag.Movie = userModel;

            return View();


        }

    }
}