using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //Console.WriteLine();
            //ColorTest();
            //Console.WriteLine();
            //BrandTest();
            //Console.WriteLine();
            //CarDetailsTest();
            //Console.WriteLine();


            //UserAddTest();
            //CustomerAddTest();
            //RentalAddTest();



            //Console.WriteLine();
            //UserTest();
            //Console.WriteLine();
            //CustomerTest();
            //Console.WriteLine();
            //RentalTest();

            //ZarOyunu();
            
        }

        private static void ZarOyunu()
        {
            Func<int> dices = delegate ()
            {
                Random random = new Random();
                return random.Next(0, 7);
            };

            Console.WriteLine("1. zar: " + dices() + "\n2. zar: " + dices());
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("CarId: {0} BrandId: {1} ColorId: {2} DailyPrice: {3} Description: {4}"
                        , car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.Description);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("BrandId: {0} BrandName: {1}", brand.Id, brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("ColorId: {0} ColorName: {1}", color.Id, color.Name);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine("CarName: {0} BrandName: {1} ColorName: {2} DailyPrice: {3}"
                        , car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "John", LastName = "Travolta", Email = "info@travolta.com", Password = "jt11*" });
            Console.WriteLine(result.Message);
            var result2 = userManager.Add(new User { FirstName = "Kelly", LastName = "Preston", Email = "wife@travolta.com", Password = "jw2020" });
            Console.WriteLine(result2.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("UserId: {0} FirstName: {1} LastName: {2} Email: {3} Password: {4}"
                    , user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }
        }
        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CompanyName = "Travolta Corp.", UserId = 2 });
            Console.WriteLine(result.Message);
            var result2 = customerManager.Add(new Customer { CompanyName = "Preston Hotel", UserId = 3 });
            Console.WriteLine(result2.Message);
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("CustomerId: {0} CompanyName: {1} UserId: {2}"
                    , customer.Id, customer.CompanyName, customer.UserId);
            }
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 4, CustomerId = 2, RentDate = new DateTime(2015, 12, 01), ReturnDate = new DateTime(2020, 08, 18) });
            Console.WriteLine(result.Message);

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("RentalId: {0} CarID: {1} CustomerId: {2} RentDate: {3} ReturnDate: {4}"
                    , rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }
        }

        
        }

       

    }

