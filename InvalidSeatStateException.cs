using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    //2. Create custom exceptions and throw them 

    internal class InvalidSeatStateException(string message) : Exception(message)
    {
    }
}
