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
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());
            CarManager carManager = new CarManager(new EFCarDal());

            Brand brand1 = new Brand { Name = "Mercedes" };
            Brand brand2 = new Brand { Name = "BMW" };

            brandManager.Add(brand1);
            brandManager.Add(brand2);

            Color color1 = new Color { Name = "Beyaz" };
            Color color2 = new Color { Name = "Siyah" };
            Color color3 = new Color { Name = "Kırmızı" };
            Color color4 = new Color { Name = "Mavi" };

            colorManager.Add(color1);
            colorManager.Add(color2);
            colorManager.Add(color3);
            colorManager.Add(color4);

            Car car1 = new Car
            {
                DailyPrice = 5000,
                Description = "A180",
                ModelYear = 2010,
            };
            //car1.Brand = brandManager.GetByID(brand1.BrandId);
            //car1.Color = colorManager.GetByID(color1.ColorId);
            car1.ColorId = colorManager.GetByID(color1.ColorId).ColorId;
            car1.BrandId = brandManager.GetByID(brand1.BrandId).BrandId;


            Car car2 = new Car
            {
                DailyPrice = -5000,
                Description = "116di",
                ModelYear = 2020,
            };
            car2.ColorId = colorManager.GetByID(color2.ColorId).ColorId;
            car2.BrandId = brandManager.GetByID(brand2.BrandId).BrandId;


            carManager.Add(car1);
            carManager.Add(car2);

            

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} - {1} - {2} - ",item.DailyPrice,item.Description,item.ModelYear);
            }




        }
    }
}
