using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Exceptions
{
    
    public class MessageAlreadyExistsException : Exception
    {
        public MessageAlreadyExistsException()
        {
        }

        public MessageAlreadyExistsException(string message) : base(message)
        {
        }

        public MessageAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
