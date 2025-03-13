using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
