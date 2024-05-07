using Microsoft.AspNetCore.Mvc;

namespace weebapp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
