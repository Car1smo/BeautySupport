using Microsoft.AspNetCore.Mvc;

namespace BeautySupport.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
