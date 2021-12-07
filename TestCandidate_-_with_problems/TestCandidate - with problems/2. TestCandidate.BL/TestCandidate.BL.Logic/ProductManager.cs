using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCandidate.Data.Components;

namespace TestCandidate.BL.Logic
{
    public class ProductManager
    {
        public string TestMe()
        {
            return "I am a live ...";
        }

        public List<Product> GetAllProducts()
        {
            DataContent _db = new DataContent();
            List<Product> result = _db.Products();
            return result;
        }

        public List<Product> GetProductsByCategoryId(int catId)
        {
            DataContent _db = new DataContent();
            List<Product> result = _db.Products().Where(x => x.CategoryId == catId).ToList();
            return result;
        }

        public List<Category> GetAllCategories()
        {
            DataContent _db = new DataContent();
            List<Category> result = _db.Categories();
            return result;
        }
    }
}
