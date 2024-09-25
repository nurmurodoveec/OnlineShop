using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Mocks
{
    public class MockCars : IallCars
    {
        private readonly IcarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                
                     new Car {
                        Name = "BMW M5 CS",
                        shortDescription = "Fastest Sedan",
                        longDescription = "The BMW M5 CS combines luxury, performance, and track-ready agility",
                        img = "https://cdn.bmwblog.com/wp-content/uploads/2022/09/BMW-M5-CS-by-Manhart-1-1534x1024.jpg",
                        price = 170000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                      new Car {
                        Name = "Mercedes CLS 6.3 AMG ",
                        shortDescription = "Powerful Elegance",
                        longDescription = "Mercedes CLS 6.3 AMG offers luxury, power, and performance",
                        img = "https://name-style.ru/assets/cache_image/brands/models/mercedes-cls-klasse-cls-63-amg_1000x600_cf9.jpg",
                        price = 129900,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                       new Car {
                        Name = "Mercedes–AMG GT 4-door Сoupe",
                        shortDescription = "Sporty Luxury",
                        longDescription = "Mercedes-AMG GT 4-Door Coupe blends performance, luxury, and style seamlessly", 
                        img = "https://www.mbusa.com/content/dam/mb-nafta/us/myco/my24/amg-gt-class/4-door/class-page/amg/2024-AMG-GT-4DR-COUPE-CH-1-1-DR.jpg",
                        price = 210000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                        new Car {
                        Name = "Mercedes-Benz G63 AMG",
                        shortDescription = "Luxury Off-Roader",
                        longDescription = "Mercedes-Benz G63 AMG delivers unmatched power, luxury, and off-road capability", 
                        img = "https://gateauto.ru/upload/resize_cache/webp/resize_cache/iblock/c87/1223_687_2/az6vrgaszi07y6rgj64tu0urtp9hvx7w.webp",
                        price = 350000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                         new Car {
                        Name = "BMW XM",
                        shortDescription = "Performance SUV",
                        longDescription = "BMW XM combines luxury, power, and advanced technology effortlessly", 
                        img = "https://s1.cdn.autoevolution.com/images/models/BMW_XM--G09--2022_main.jpg",
                        price = 185000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                          new Car {
                        Name = "Rolls-Royce Cullinan",
                        shortDescription = "Ultimate Luxury",
                        longDescription = "Rolls-Royce Cullinan offers unmatched luxury and off-road capability.",
                        img = "https://www.edmunds.com/assets/m/cs/bltda892b5965a01a82/663a8ef0f807b2a238e9b002/2025_Rolls_Royce_Cullinan_5_815.jpg",
                        price = 485000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.Last()},
                          new Car {
                        Name = "ZEEKR 001",
                        shortDescription = "Electric Sedan",
                        longDescription = "Zeekr 001 delivers innovative design, luxury, and electric performance",
                        img = "https://zeekr-cars.uz/img/exterior-color-phantom-black@2x.png",
                        price = 56000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.First()},
                          new Car {
                        Name = "BYD Song L",
                        shortDescription = "Versatile SUV",
                        longDescription = "BYD Song L combines electric efficiency, modern design, and practicality",
                        img = "https://repost.uz/storage/uploads/0-1691748620-avto11-post-material.jpeg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.First()},
                             new Car {
                        Name = "Tesla S",
                        shortDescription = "Electric Innovator",
                        longDescription = "Tesla revolutionizes transportation with electric vehicles and sustainable energy",
                        img = "https://autopremiumgroup.ru/m/_versions/catalog/autos/2022/tesla_model_s_2022_liftbek/plaid/1pw_plaid_tesla_s_2022_image_series.jpg",
                        price = 70000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.Allcategories.First()},
                };
            }
        }

        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }

}
