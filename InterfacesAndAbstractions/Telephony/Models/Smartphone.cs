using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;
using Telephony.Exeptions;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberExceptions();
            }
            return $"Calling... {number}";

        }

        public string Browse(string url)
        {
            if (url.Any(l=>char.IsDigit(l)))
            {
                throw new InvalidUrlException();
            }
            return $"Browsing: {url}!";
        }


    }
}
