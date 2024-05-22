using Microsoft.AspNetCore.Mvc;

namespace Megyek.Controllers
{
    public class UtolsoController : Controller
    {
        public IActionResult UtolsoValasztas()
        {
            return View();
        }
    }
}
