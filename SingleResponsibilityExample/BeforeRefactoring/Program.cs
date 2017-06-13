using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Ball", 100);
            
            product.SaveProductToDatabase();
            product.EmailProduct();

            Console.ReadKey();
        }
    }
}
