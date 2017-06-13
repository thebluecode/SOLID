using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Ball", 100);

            var repository = new Repository();
            repository.Save(product);

            Mailer mailer = new Mailer();
            mailer.Email(product);

            Console.ReadKey();
        }
    }
}
