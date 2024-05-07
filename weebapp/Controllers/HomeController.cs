using Microsoft.AspNetCore.Mvc;
using weebapp.Models;

namespace weebapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Jobs job = new Jobs()
            {
                Name="Fehle",
                Description="Fehleleruk",
                BackGroundPhoto="tosuuuu.jpg"

            };
            Jobs job2 = new Jobs()
            {
                Name = "Doner Ustasi",
                Description = "3 manata 1 doner 1 ayran",
                BackGroundPhoto = "denci.jpeg"

            };
            List<Jobs> jobs = new List<Jobs>();


            return View(jobs);
        }
    }
}
