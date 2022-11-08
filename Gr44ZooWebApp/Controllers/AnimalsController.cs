using Gr44ZooWebApp.Models.Repos;
using Gr44ZooWebApp.Models.Servises;
using Gr44ZooWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gr44ZooWebApp.Controllers
{

    public class AnimalsController : Controller
    {
        IAnimalsService _animalsService;
        public AnimalsController()
        {
            _animalsService = new AnimalsService(new InMemoryRepo());
        }
        public IActionResult ZooPark()
        {
            return View(_animalsService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateAnimalViewModel());
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreateAnimalViewModel createAnimal)
        {
            if (ModelState.IsValid)
            {
                _animalsService.Create(createAnimal);
                return RedirectToAction(nameof(ZooPark));
            }
            return View(createAnimal);
        }
    }
}
