using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSQL
{
     public interface IProductRepository
     {
        IEnumerable<Product> GetAllProducts();
    }
}
