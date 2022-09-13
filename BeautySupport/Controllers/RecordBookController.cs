using BeautySupport.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeautySupport.Controllers
{
    public class RecordBookController : Controller
    {
        private readonly ILogger<RecordBookController> _logger;

        public RecordBookController(ILogger<RecordBookController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult List()
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