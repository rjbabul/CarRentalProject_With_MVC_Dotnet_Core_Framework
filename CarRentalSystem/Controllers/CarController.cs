using CarRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using CarRentalSystem.RepositoryModel;
 
namespace CarRentalSystem.Controllers
{
    public class CarController : Controller 
    {
        RepositoryModels db = new RepositoryModels();

                    /* HTTP GET Request*/

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create( )
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShowList()
        {
            List<CarCreate> car = db.GetAllCar();
            return View(car);
        }
        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            CarCreate acar = db.GetById(id);
            if (acar == null)
            {
                return NotFound();
            }
            return View(acar);

        }
       
                        /* HTTP post request */

        [HttpPost]
        public IActionResult Create(CarCreate car)
        {
            bool success = db.Add(car); ;
            if (success)
            {
                 
                return View();
            }
            else
            {   
                return View( );
            }
        }
        [HttpPost]
        public IActionResult UpdateCar(CarCreate car)
        {

            bool isSuccess = db.Update(car);
            if (!isSuccess)
                return NotFound();

            return Redirect("~/car/ShowList");
        }

        [HttpPost]
        public IActionResult DeleteCar(int id)
        {
            CarCreate acar = db.GetById(id);
            if (acar != null)
            {
                bool isSuccess = db.Delete(acar);
                
                if (isSuccess)
                {
                    return Redirect("~/Car/ShowList");
                }
            }
            return NotFound();
        }
    }
}
