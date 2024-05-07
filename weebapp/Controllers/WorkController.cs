using Microsoft.AspNetCore.Mvc;

namespace weebapp.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
