using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();    

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();

            Console.WriteLine("Eklemek istediğiniz şeyin sayısını girin");
            Console.WriteLine("Marka eklemk içn 1");
            Console.WriteLine("Renk eklemek içn 2");
            Console.WriteLine("Araba eklemek için 3");
            string girilenSayi = Console.ReadLine();

            if (girilenSayi == "1")
            {

                Console.WriteLine("Markanın adını giriniz");
                brand.Name = Console.ReadLine();
                brandManager.Add(brand);

            }
            else if (girilenSayi == "2")
            {
                Console.WriteLine("Markanın adını giriniz");
                color.Name = Console.ReadLine();
                colorManager.Add(color);
            }

            else if (girilenSayi == "3")
            {
                Console.WriteLine("Model adı girin");
                car.Description = "Hacı Murat";
                car.BrandId = 1;
                car.ColorId = 6;
                car.ModelYear = "1975";
                car.DailyPrice = 175000;
                //BrandId ColorId ModelYear DailyPrice Description
                bool sonuc=carManager.Add(car);
                Console.WriteLine(sonuc);





            }
            

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.CarId);
            //    Console.WriteLine(car.Description);
            //}

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Description);
            //}


        }
    }

}