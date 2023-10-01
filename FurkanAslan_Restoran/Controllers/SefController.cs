using Microsoft.AspNetCore.Mvc;

namespace FurkanAslan_Restoran.Controllers
{
    public class SefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
