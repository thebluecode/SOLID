using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RefactoredByInterfaces
{
    public interface Parser
    {
        string Parse<T>(T obj);
    }
}
