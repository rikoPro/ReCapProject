using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { Id = 3, BrandId = 1, ColorId = 2, ModelYear = 1977, DailyPrice = 0, Description = "Station Wagon" });

            
            foreach (var item in carManager.GetCarByBrandId(1))
            {
                Console.WriteLine(item.BrandId + " " + item.Description);
            }

            

            //var car = carManager.GetById(2);
            //Console.WriteLine(car.Description);
        }
    }
}
