using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;
using Telephony.Exeptions;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!number.All(ch=>char.IsDigit(ch)))
            {
                throw new InvalidNumberExceptions();
            }
            return $"Dialing... {number}";

        }
    }
}
