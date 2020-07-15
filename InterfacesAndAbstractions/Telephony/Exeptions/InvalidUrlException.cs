using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exeptions
{
    public class InvalidUrlException : Exception
    {
        public const string EXC_MSG = "Invalid URL!";

        public InvalidUrlException() : base(EXC_MSG)
        {
        }
        public InvalidUrlException(string message):base(message)
        {
        }
    }
}
