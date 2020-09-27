using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult personal()
        {
            personal personal = new personal() { name = "ali haider" };

            return View(personal);
        }
    }
}