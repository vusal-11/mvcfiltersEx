using Microsoft.AspNetCore.Mvc;
using mvc_Filters.Filters;
using mvc_Filters.Models;
using System.Diagnostics;

namespace mvc_Filters.Controllers
{

        //[TypeFilter(typeof(ApiKeyQueryAuthorization))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [DateTimeExec]
        public IActionResult Index()
        {
            throw new KeyNotFoundException();
        }

        //[TypeFilter(typeof(MyAuthorizationFiler))]  
        public IActionResult Welcome()
        {
            return View();
        }

        [LastEnterDate]
        public IActionResult Privacy()
        {
            int a = 0;
            int b = 5/a;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}