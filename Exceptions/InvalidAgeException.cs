using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Prgrams.Exceptions
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg): base(msg)
        {

        }
    }
}
