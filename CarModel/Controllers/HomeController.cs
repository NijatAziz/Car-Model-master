using CarModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace CarModel.Controllers
{
    public class HomeController : Controller
    {
        private List<Car> allCars = new List<Car>
    {
        new Car { CarModel = new Model { ID = 1, Name = "Ford" }, CarBrand = new Brand { ID = 1, Name = "Rolls roys" }, Name = "Focus" },
        new Car { CarModel = new Model { ID = 2, Name = "Toyota" }, CarBrand = new Brand{ ID = 2, Name = "M5" }, Name= "Camry" },
        new Car { CarModel= new Model { ID = 3, Name = "Honda" }, CarBrand = new Brand{ ID = 3, Name = "Q7" }, Name= "Civic" },
    };

        public ActionResult Index()
        {
            return View(allCars);
        }
        public ActionResult FiltrModel(int modelID)
        {
            var filtredModel = allCars.Where(a => a.CarModel.ID == modelID).ToList();
            return View("Index", filtredModel);
        }

        public ActionResult FiltrColor(int colorID)
        {
            var filtredCars = allCars.Where(a => a.CarBrand.ID == colorID).ToList();
            return View("Index", filtredCars);
        }

        public ActionResult FiltrModelAndBrands(int modelID, int colorID)
        {
            var filtredCars = allCars.Where(a => a.CarModel.ID == modelID && a.CarBrand.ID == colorID).ToList();
            return View("Index", filtredCars);
        }
    }
}