using Microsoft.AspNetCore.Mvc;

namespace FurkanAslan_Restoran.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdmPage()
        {
            return View();
        }
    }
}
