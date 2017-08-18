using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Exceptions
{
    public class MessageDoesNotExistException : Exception
    {
        public MessageDoesNotExistException()
        {
        }

        public MessageDoesNotExistException(string message) : base(message)
        {
        }

        public MessageDoesNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
