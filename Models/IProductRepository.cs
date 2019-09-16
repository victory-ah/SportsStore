using System.Linq;


namespace SportsStore6.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
