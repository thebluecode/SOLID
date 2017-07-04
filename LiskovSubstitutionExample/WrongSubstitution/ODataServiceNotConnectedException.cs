using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongSubstitution
{
    public class ODataServiceNotConnectedException : Exception
    {
        public ODataServiceNotConnectedException() : base() { }
        public ODataServiceNotConnectedException(string message) : base(message) { }
        public ODataServiceNotConnectedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
