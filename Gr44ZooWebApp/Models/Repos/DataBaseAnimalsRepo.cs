using Gr44ZooWebApp.Data;

namespace Gr44ZooWebApp.Models.Repos
{
    public class DataBaseAnimalsRepo : IAnimalsRepo
    {
        readonly ZooDbContext _zooDbContext;
        public DataBaseAnimalsRepo(ZooDbContext zooDbContext)
        {
            _zooDbContext = zooDbContext;
        }

        public Animal Create(Animal animal)
        {
            throw new NotImplementedException();
        }


        public List<Animal> GetAll()
        {
            return _zooDbContext.Animals.ToList();
        }

        public Animal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetBySpecies(string species)
        {
            throw new NotImplementedException();
        }

        public void Update(Animal animal)
        {
            throw new NotImplementedException();
        }
        public void Delete(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
