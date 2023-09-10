using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    public class PrintingException : Exception
    {
        public PrintingException(string message) : base(message)
        {

        }
    }
}
