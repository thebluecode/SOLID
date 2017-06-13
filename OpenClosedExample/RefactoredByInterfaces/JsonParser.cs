using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredByInterfaces
{
    public class JsonParser : Parser
    {
        public string Parse<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
