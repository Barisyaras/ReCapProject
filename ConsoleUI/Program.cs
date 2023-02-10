using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI 
{
    class program 
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
                Console.WriteLine(car.Description);
            }
        }
    }

}