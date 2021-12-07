using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCandidate.Data.Components
{
    public class DataContent
    {
        public List<Product> Products()
        {
            List<Product> products = new List<Product>() {
            new Product() { Id = 1, CategoryId = 1, Name = "Computer" },
            new Product() { Id = 2, CategoryId = 1, Name = "Switch" },
            new Product() { Id = 3, CategoryId = 1, Name = "Router" },
            new Product() { Id = 4, CategoryId = 2, Name = "Chair" },
            new Product() { Id = 5, CategoryId = 2, Name = "Table" },
            new Product() { Id = 6, CategoryId = 3, Name = "Car" }
        };
            return products;
        }

        public List<Category> Categories()
        {
            List<Category> Categories = new List<Category>() {
            new Category() { Id = 1, Name = "Computers" },
            new Category() { Id = 2, Name = "Home" },
            new Category() { Id = 3, Name = "Other" }
        };
            return Categories;
        }
    }
}
