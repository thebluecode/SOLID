using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeRefactoring
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void SaveProductToDatabase()
        {
            Console.WriteLine("Saving Product: {{ Name: '{0}', Price: {1} }}", this.Name, this.Price);
        }

        public void EmailProduct()
        {
            Console.WriteLine("Emailing Product: {{ Name: '{0}', Price: {1} }}", this.Name, this.Price);
        }
    }
}
