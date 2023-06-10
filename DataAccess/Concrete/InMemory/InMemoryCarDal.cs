using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=920000,ModelYear=2015,Description="AUDi A6"},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=1253000,ModelYear=2023,Description="TOGG T10X"},
                new Car{CarId=3,BrandId=2,ColorId=3,DailyPrice=953000,ModelYear=2023,Description="TOGG T10X"},
                new Car{CarId=4,BrandId=3,ColorId=4,DailyPrice=100000,ModelYear=2019,Description="BMW 520"},
                new Car{CarId=5,BrandId=4,ColorId=1,DailyPrice=2000000,ModelYear=2015,Description="BMW 320i"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c=>c.BrandId==BrandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description=car.Description;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
        }
    }
}
