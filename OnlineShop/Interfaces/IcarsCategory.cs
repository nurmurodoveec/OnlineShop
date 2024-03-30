using OnlineShop.Models;

namespace OnlineShop.Interfaces
{
    public interface IcarsCategory
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
