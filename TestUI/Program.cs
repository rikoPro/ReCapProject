using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.DailyPrice);
            }
            var car = carManager.GetById(2);
            Console.WriteLine(car.Description);
        }
    }
}
