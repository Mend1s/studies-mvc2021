using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExpection : ApplicationException
    {
        public NotFoundExpection(string message) : base(message)
        {

        }
    }
}
