using Gr44ZooWebApp.Models.Repos;
using Gr44ZooWebApp.Models.Servises;
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
            return View();
        }
    }
}
