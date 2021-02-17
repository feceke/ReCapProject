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


            
            ListBrands();
            ListColors();
            CarTest();
        }

        private static void CarTest()
        {
            Console.WriteLine();
            Console.WriteLine("Tüm Özellikler\n-------------------");
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice + " " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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

    }
}
