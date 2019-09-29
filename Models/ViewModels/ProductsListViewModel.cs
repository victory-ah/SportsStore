using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore6.Models;

namespace SportsStore6.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}
