using System.Collections.Generic;

namespace DiPatternSample
{   
    public class DAL:IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>{
                new Product {Id = 1, Name = "Kalem 1", Stock = 100, Price = 100},
                new Product {Id = 2, Name = "Kalem 2", Stock = 100, Price = 100},
                new Product {Id = 3, Name = "Kalem 3", Stock = 100, Price = 100},
                new Product {Id = 4, Name = "Kalem 4", Stock = 100, Price = 100}
            };
        }
    }
}