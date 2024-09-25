using OnlineShop.Models;

namespace OnlineShop.Interfaces
{
    public interface IallCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
