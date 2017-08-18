using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Exceptions
{
    public class BadLogInException : Exception
    {
        public BadLogInException()
        {
        }

        public BadLogInException(string message) : base(message)
        {
        }

        public BadLogInException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
