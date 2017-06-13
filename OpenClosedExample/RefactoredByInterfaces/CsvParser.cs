using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredByInterfaces
{
    public class CsvParser : Parser
    {
        public string Parse<T>(T obj)
        {
            var csv = " Object parsed to Csv ";

            return csv;
        }
    }
}
