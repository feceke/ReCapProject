using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARABA EKLEME
            // Alttaki 2 satır en son eklenen araba id sini içerir. Ekleme Yapmak için yorumu kaldırıp id +1 düzenle.
            //CarManager carManager1 = new CarManager(new EfCarDal());
            //carManager1.Add(new Entities.Concrete.Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 300, ModelName = "Volkswagen Transporter", ModelYear = "2000", Description = "Dizel" });


            // TÜM ARABALARI LİSTELEME
            //ListCars();
            //ListBrands();
            //ListColors();

            ListWithJoin();
        }

        private static void ListWithJoin()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName +" "+ car.DailyPrice+" "+car.Description);
            }
        }

        private static void ListColors()
        {
            Console.WriteLine();
            Console.WriteLine("Renkler\n-----------");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ListBrands()
        {
            Console.WriteLine();
            Console.WriteLine("Markalar\n-----------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ListCars()
        {
            Console.WriteLine("Arabalar\n-----------");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelName + "\t" + car.ModelYear + "\t" + car.Description + "\t" + car.DailyPrice);
            }
        }
    }
}
