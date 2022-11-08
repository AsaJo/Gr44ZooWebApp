using Gr44ZooWebApp.Models.Repos;
using Gr44ZooWebApp.Models.Servises;
using Gr44ZooWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

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

                try// STEP2 
                {
                    _animalsService.Create(createAnimal);
                }
                catch (ArgumentException exception)
                {
                    // Add our own message
                    ModelState.AddModelError("Animal & species", exception.Message);// Key And value
                    return View(createAnimal);
                }


                return RedirectToAction(nameof(ZooPark));
            }
            return View(createAnimal);
        }
    }
}
