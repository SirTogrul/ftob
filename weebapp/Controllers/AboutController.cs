using Microsoft.AspNetCore.Mvc;

namespace weebapp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
