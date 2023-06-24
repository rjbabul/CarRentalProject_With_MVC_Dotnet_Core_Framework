using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class ShowCarList : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
