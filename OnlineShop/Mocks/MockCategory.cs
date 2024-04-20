using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Mocks
{
    public class MockCategory : IcarsCategory
    {
        public IEnumerable<Category> Allcategories
        {
            get
            {
                return new List<Category> {
                    new Category{categoryName= "Electro Transports",Description="Modern type transports"},
                    new Category{categoryName= "Classic Transports", Description="Cars with internal burning"}
                
                };
            }
        }
    }
}
