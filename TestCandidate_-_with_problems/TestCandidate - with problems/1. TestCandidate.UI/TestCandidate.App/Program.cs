using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCandidate.BL.Logic;
using TestCandidate.Data.Components;
using TestCandidate.Logger;

namespace TestCandidate.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pManager = new ProductManager();

            PrintCategories(pManager);
            Console.WriteLine("Enter category number: ");
            string sUserCatNum = Console.ReadLine();
            int nUserCatNum = int.Parse(sUserCatNum);
            List<Product> productByUserChoice = pManager.GetProductsByCategoryId(nUserCatNum);
            // Make space (line brake)
            Console.WriteLine();
            Console.WriteLine("Here are the products from your category: ");
            PrintProducts(productByUserChoice);

            PrintProductPercentage(pManager, productByUserChoice);

            Console.WriteLine("DONE !!!");

            Console.ReadLine();
        }

        private static void PrintCategories(ProductManager pManager)
        {
            LogManager.WriteToLog("[Start] [PrintCategories]");
            Console.WriteLine("Categories: ");
            List<Category> categories = pManager.GetAllCategories();
            foreach (var cat in categories)
            {
                Console.WriteLine(string.Format("Id: {0}\tName: {1}", cat.Id, cat.Name));
            }
            // Make space (line brake)
            Console.WriteLine();
            LogManager.WriteToLog("[End] [PrintCategories]");

        }

        private static void PrintProducts(List<Product> products)
        {
            LogManager.WriteToLog("[Start] [PrintProducts]");
            Console.WriteLine("Products: ");
            foreach (var product in products)
            {
                Console.WriteLine(string.Format("Id: {0}\tName: {1}", product.Id, product.Name));
            }
            // Make space (line brake)
            Console.WriteLine();
            LogManager.WriteToLog("[End] [PrintProducts]");
        }

        private static void PrintProductPercentage(ProductManager pManager, List<Product> productsFromUser)
        {
            LogManager.WriteToLog("[Start] [CalculatePrice]");
            // Make space (line brake)
            Console.WriteLine();
            List<Product> allProducts = pManager.GetAllProducts();
            float result = allProducts.Count / productsFromUser.Count;
            int pleaseChangeThisTo100 = 0;
            int divideNumber = 10000 / pleaseChangeThisTo100;
            float precentage = productsFromUser.Count / (float)allProducts.Count * divideNumber;
            Console.WriteLine(string.Format("You choose category with {0} products, which is {1}% from all products.", productsFromUser.Count, precentage));
            LogManager.WriteToLog("[End] [CalculatePrice]");
        }
    }
}
