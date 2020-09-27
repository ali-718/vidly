using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        private MyDbContext _context;

        public TestController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            List<Test> testData = _context.Test.ToList();

            ViewBag.Tests = testData;

            return View();
        }
    }
}