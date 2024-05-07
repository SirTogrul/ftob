using Microsoft.AspNetCore.Mvc;

namespace weebapp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
