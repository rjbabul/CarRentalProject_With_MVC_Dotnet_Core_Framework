using CarRentalSystem.Database;
using CarRentalSystem.Models;

namespace CarRentalSystem.RepositoryModel
{
    public class RepositoryModels
    {
        ApplicationDbContext _db;

        public RepositoryModels()
        {
            _db = new ApplicationDbContext();
        }

        public bool Add(CarCreate car)
        {
            _db.cars.Add(car);
            return _db.SaveChanges() > 0;
        }

        public bool AddRange(ICollection<CarCreate> cars)
        {
            _db.cars.AddRange(cars);
            return _db.SaveChanges() > 0;
        }

        public bool Update(CarCreate car)
        {
            _db.cars.Update(car);

            return _db.SaveChanges() > 0;
        }

        public bool UpdateRange(ICollection<CarCreate> cars)
        {
            _db.cars.UpdateRange(cars);
            return _db.SaveChanges() > 0;
        }

        public bool Delete(CarCreate acar)
        {
            _db.cars.Remove(acar);
            return _db.SaveChanges() > 0;
        }

        public CarCreate GetById(int id)
        {
            return _db.cars.FirstOrDefault(c => c.Id == id);
        }

        public List<CarCreate> GetAllCar()
        {
            return _db.cars.ToList();
        }
    }
}
