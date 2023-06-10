using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    private static void Main(string[] args)
    {

        //CarManager carManager = new CarManager(new EfCarDal());

        //var result = carManager.GetCarDetails();

        //if (result.Success)
        //{
        //    foreach (var car in result.Data)
        //    {
        //        Console.WriteLine("Araç : {0} Marka : {1} Renk : {2}  Fiyatı : {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(result.Message);
        //}

        //UserManager userManager = new UserManager(new EfUserDal());
        //userManager.Add(new User
        //{
        //    FirstName = "Batuhan",
        //    LastName = "Güngör",
        //    Email = "batuhan@batuhan.com",
        //    Password = "123456789"
        //});
        //foreach (var user in userManager.GetAll().Data)
        //{
        //    Console.WriteLine(user.FirstName);
        //}

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        customerManager.Add(new Customer
        {
            UserId=2,
            CompanyName="Kodlama.io"
        });



    }
}