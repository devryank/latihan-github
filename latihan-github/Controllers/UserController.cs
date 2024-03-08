using Microsoft.AspNetCore.Mvc;

namespace latihan_github.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
