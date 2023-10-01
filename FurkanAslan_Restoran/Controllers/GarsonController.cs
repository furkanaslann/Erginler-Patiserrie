using Microsoft.AspNetCore.Mvc;

namespace FurkanAslan_Restoran.Controllers
{
    public class GarsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
