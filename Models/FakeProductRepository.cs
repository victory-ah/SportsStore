using System.Collections.Generic;
using System.Linq;


namespace SportsStore6.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                Name = "Victoria\'s Signature Football",
                Price = 25,
            },
            new Product
            { Name = "Surfboard",
                Price = 179,
            },

            new Product
            { Name = "Running shoes",
                Price = 95,
            },

        }.AsQueryable<Product>();
            
    }
}
