using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                Name = "Ball",
                Price = 100
            };

            var repository = new ODataRepository();
            repository.Insert(product);

            var products = repository.GetList();

            foreach (var item in products)
            {
                Console.WriteLine("Name: {0}, Price: {1}", item.Name, item.Price);
            }

            Console.ReadKey();
        }
    }
}
