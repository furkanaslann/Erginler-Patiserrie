using FurkanAslan_Restoran.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FurkanAslan_Restoran.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

		public IActionResult About()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Price()
		{
			return View();
		}
		public IActionResult Subscribe()
		{
			return View();
		}
		
		public IActionResult SignUp()
		{
			return View();
		}

        public IActionResult SignUpTrue()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}