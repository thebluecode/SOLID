using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredByInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Boll", 100);

            var json = new JsonParser().Parse(product);

            var xml = new XmlParser().Parse(product);

            Console.WriteLine(json);

            Console.WriteLine();

            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }
}
