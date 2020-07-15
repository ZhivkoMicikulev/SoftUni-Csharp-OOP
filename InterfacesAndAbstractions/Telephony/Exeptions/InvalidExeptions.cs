using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exeptions
{
    public class InvalidNumberExceptions : Exception
    {
        private const string EXC_MSG = "Invalid number!";



        public InvalidNumberExceptions() : base(EXC_MSG)
        {
        }
        public InvalidNumberExceptions(string message) :base(message)
        {

        }
    }
}
