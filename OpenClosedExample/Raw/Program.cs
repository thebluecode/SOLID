using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Boll", 100);

            var json = new Parser().Parse(product, "json");

            var xml = new Parser().Parse(product, "xml");

            Console.WriteLine(json);

            Console.WriteLine();

            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }
}
