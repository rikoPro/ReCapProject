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
            
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            //BrandTestMethod(brandManager);



            //Console.WriteLine("**********************************");

            // ColorTestMethod();



            // Console.WriteLine("**********************************");
            // CarDetailTestMethod(carManager);
            RentalDetailTestMethod();

        }

        

        private static void BrandTestMethod(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void ColorTestMethod()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ColorId + " " + item.ColorName);

            }
            Console.WriteLine("**********************************");
        }

        private static void CarTestMethod(CarManager carManager)
        {
            var result = carManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Id + " " + item.Description);

            }
            Console.WriteLine("**********************************");
        }

        private static void CarDetailTestMethod(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarId+ " " + item.Description + " " + item.BrandName + " " + item.DailyPrice);

            }
            Console.WriteLine("**********************************");
        }

        private static void RentalDetailTestMethod()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            foreach (var item in result.Data)
            {
                Console.WriteLine("BrandName : "+item.BrandName+"\n"+"Customer Company Name : "+item.CompanyName +"\n" + "Car Description : "+item.Description+"\n"+"Rent Date : "+item.RentDate+"\n");
                Console.WriteLine("**********************************");
            }
        }
    }
}
