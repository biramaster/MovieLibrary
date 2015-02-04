using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class CustomException : ApplicationException
    {
        public CustomException() : base("This object has some missing information.") { }

        public CustomException(string reason)
            : base(reason)
        {
            
        }
    }
}
