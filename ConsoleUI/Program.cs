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
            //carManager1.Add(new Entities.Concrete.Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 300, ModelName = "Volkswagen Transporter", ModelYear = "2000", Description = "Dizel" });

            
            // TÜM ARABALARI LİSTELEME
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.ModelName + " " + car.ModelYear +" "+ car.Description+" "+ car.DailyPrice);
            }
        }
    }
}
