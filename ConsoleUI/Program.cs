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


            //// Brand ve color CRUD işlemlerinin simülasyonu
            //#region 

            //Brand brand1 = new Brand { Name = "Mercedes" };
            //Brand brand2 = new Brand { Name = "BMW" };
            //Color color1 = new Color { Name = "Beyaz" };
            //Color color2 = new Color { Name = "Siyah" };
            //Color color3 = new Color { Name = "Kırmızı" };
            //Color color4 = new Color { Name = "Mavi" };


            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);
            //colorManager.Add(color4);


            //Console.WriteLine("***********************************************");
            //Console.WriteLine("***********************************************");
            //Console.WriteLine(" ---------- GETALL İŞLEMİ SONUCU ---------------");
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            ////     DELETE OPERATION

            ////Console.WriteLine("***********************************************");
            ////Console.WriteLine("***********************************************");
            ////Console.WriteLine(" ---------- SİLME İŞLEMİ SONUCU ---------------");
            ////brandManager.Delete(brand1);
            ////colorManager.Delete(color1);

            ////foreach (var item in colorManager.GetAll())
            ////{
            ////    Console.WriteLine(item.Name);
            ////}

            ////foreach (var item in brandManager.GetAll())
            ////{
            ////    Console.WriteLine(item.Name);
            ////}

            ////    UPDATE OPERATİON 

            //Console.WriteLine("***********************************************");
            //Console.WriteLine("***********************************************");
            //Console.WriteLine(" ---------- UPDATE İŞLEMİ SONUCU ---------------");

            //brand2.Name = "FIAT";
            //color2.Name = "Bi siyah bi beyaz";

            //brandManager.Update(brand2);
            //colorManager.Update(color2);

            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //#endregion

            //// Car CRUD işlemleri simülasyonu
            //#region

            //Console.WriteLine("*******************************");
            //Console.WriteLine("------ CAR CRUD İŞLEMLERİ ------");

            //Car car1 = new Car
            //{
            //    DailyPrice = 5000,
            //    Description = "A180",
            //    ModelYear = 2010,
            //};
            //car1.ColorId = colorManager.Get(c => c.ColorId == color1.ColorId).ColorId;
            //car1.BrandId = brandManager.Get(b => b.BrandId == brand1.BrandId).BrandId;


            //Car car2 = new Car
            //{
            //    DailyPrice = -5000,
            //    Description = "116di",
            //    ModelYear = 2020,
            //};
            //car2.ColorId = colorManager.Get(c => c.ColorId == color2.ColorId).ColorId;
            //car2.BrandId = brandManager.Get(b => b.BrandId == brand2.BrandId).BrandId;


            //Car car3 = new Car
            //{
            //    DailyPrice = 1800,
            //    Description = "330Ci",
            //    ModelYear = 2005,
            //};
            //car3.ColorId = colorManager.Get(c => c.ColorId == color3.ColorId).ColorId;
            //car3.BrandId = brandManager.Get(b => b.BrandId == brand2.BrandId).BrandId;

            //carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Add(car3);

            //Console.WriteLine("***********************************************");
            //Console.WriteLine("***********************************************");
            //Console.WriteLine(" ---------- GETALL İŞLEMİ SONUCU ---------------");
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine("{0} - {1} - {2} - ", item.DailyPrice, item.Description, item.ModelYear);
            //}

            //// DELETE İŞLEMİ

            //Console.WriteLine("***********************************************");
            //Console.WriteLine("***********************************************");
            //Console.WriteLine(" ---------- DELETE İŞLEMİ SONUCU ---------------");

            //carManager.Delete(car1);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine("{0} - {1} - {2} - ", item.DailyPrice, item.Description, item.ModelYear);
            //}

            //// UPDATE İŞLEMİ

            //Console.WriteLine("***********************************************");
            //Console.WriteLine("***********************************************");
            //Console.WriteLine(" ---------- UPDATE İŞLEMİ SONUCU ---------------");

            //car3.DailyPrice = 3333;
            //car3.ModelYear = 1995;
            //carManager.Update(car3);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine("{0} - {1} - {2} - ", item.DailyPrice, item.Description, item.ModelYear);
            //}
            //#endregion

            foreach (var item in carManager.GetCarsDetails().Data)
            {
                Console.WriteLine(item.CarName + " - " + item.BrandName + " - " + item.ColorName + " - " + item.DailyPrice);
            }

            AddingErroneousCar(carManager);

        }

        private static void AddingErroneousCar(CarManager carManager)
        {
            Car car4 = new Car { ModelYear = 2021, DailyPrice = 35000, Description = "Z", BrandId = 2069, ColorId = 2137 };

            var result = carManager.Add(car4);

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine(result.Message);
        }
    }
}
