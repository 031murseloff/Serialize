using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerException
{
    public class NullpathException:Exception
    {
        public NullpathException() { }  
        public NullpathException(string message) : base(message) { }
    }
}
