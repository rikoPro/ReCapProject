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

            //carManager.Add(new Car { Id = 4, BrandId = 2, ColorId = 1, ModelYear = 1999, DailyPrice = 5000, Description = "Station Wagon" });
            //colorManager.Add(new Color { ColorId = 33, ColorName = "Pink" });
            //brandManager.Add(new Brand { BrandId = 33, BrandName = "Mitsubishi" });

            //carManager.Delete(2);
            //colorManager.Delete(33);
            //brandManager.Delete(33);


            //CarTestMethod(carManager);
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add( new Color() { ColorId = 11, ColorName = "sgfagsfh" });
            //Color color1 = colorManager.GetById(11);
            //ColorTestMethod();
            //colorManager.Delete(color1);
            Console.WriteLine("**********************************");

            //ColorTestMethod();
            //BrandTestMethod(brandManager);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice );
            }


            Console.WriteLine("**********************************");
            
            
            //Console.WriteLine(color1.ColorId + " / " + color1.ColorName);
            //Brand brand1 = brandManager.GetById(1);
            //Console.WriteLine(brand1.BrandId + " / " + brand1.BrandName);


            //Console.WriteLine(carManager.GetById(4).DailyPrice);



            //var car = carManager.GetById(2);
            //Console.WriteLine(car.Description);

            //           1. CarRental Projenizde Core katmanı oluşturunuz.
            //           2. IEntity, IDto, IEntityRepository, EfEntityRepositoryBase                        dosyalarınızı 9.gün dersindeki gibi oluşturup ekleyiniz.
            //           3. Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır              hale getiriniz.
            //           4. Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
            //           5. Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu: IDto oluşturup 3 tabloya join yazınız)
        }

        private static void BrandTestMethod(BrandManager brandManager)
        {
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandId + " " + item.BrandName);
            }
        }

        private static void ColorTestMethod()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.ColorId + " " + item.ColorName);

            }
            Console.WriteLine("**********************************");
        }

        private static void CarTestMethod(CarManager carManager)
        {
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Description);

            }
            Console.WriteLine("**********************************");
        }
    }
}
