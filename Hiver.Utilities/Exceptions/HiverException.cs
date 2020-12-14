using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Utilities.Exceptions
{
    public class HiverException : Exception
    {
        public HiverException()
        {
        }

        public HiverException(string message)
            : base(message)
        {
        }

        public HiverException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
