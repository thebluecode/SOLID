using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Raw
{
    public class Parser
    {
        public string Parse<T>(T obj, string type)
        {
            if ("json".Equals(type))
            {
                return JsonConvert.SerializeObject(obj);
            }
            else if ("xml".Equals(type))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, obj);
                    return textWriter.ToString();
                }
            }

            return string.Empty;
        }
    }
}
