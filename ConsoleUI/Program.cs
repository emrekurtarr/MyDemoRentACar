using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car { ID = 6, BrandID = 4, ColorID = 1, DailyPrice = 5000, Description = "My new car", ModelYear = 2021 });

            // myCar ile referansını tutup delete işlemi yapmak için 

            Car myCar = new Car { ID = 7, BrandID = 2, ColorID = 2, DailyPrice = 8000, Description = "My old car", ModelYear = 1998 };
            carManager.Add(myCar);

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Update sonrası : ");

            myCar.Description = "My old car updated version !";
            myCar.DailyPrice = 18000;

            carManager.Update(myCar);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Delete işlemi sonrası : ");

            carManager.Delete(myCar);

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }





        }
    }
}
