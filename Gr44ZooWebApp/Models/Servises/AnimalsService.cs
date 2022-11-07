using Gr44ZooWebApp.Models.Repos;
using Gr44ZooWebApp.Models.ViewModels;

namespace Gr44ZooWebApp.Models.Servises
{
    public class AnimalsService : IAnimalsService
    {
        IAnimalsRepo _animalsRepo;
        public AnimalsService(IAnimalsRepo animalsRepo)
        {
            _animalsRepo = animalsRepo;
        }
        public Animal Create(CreateAnimalViewModel createAnimal)
        {
            Animal animal = new Animal()
            {
                AnimalName = createAnimal.AnimalName,
                Species = createAnimal.Species,
                CalledByName = createAnimal.CalledByName,
                Quantity = createAnimal.Quantity
            };
            animal = _animalsRepo.Create(animal);
            return animal;
        }

        public Animal FindById(int id)
        {
            return _animalsRepo.GetById(id);
        }
        public List<Animal> GetAll()
        {
            return _animalsRepo.GetAll();
        }
        public List<Animal> FindBySpecies(string species)
        {
            return _animalsRepo.GetBySpecies(species);
        }


        public void Edit(int id, CreateAnimalViewModel editAnimal)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
