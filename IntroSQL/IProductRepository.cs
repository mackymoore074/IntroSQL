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
        public void CreateProduct(string name, double price, int categoryID);
        public void UpdateProductName(int productID, string updatedName);
        public void DeleteProduct(int productID);

    }
}
