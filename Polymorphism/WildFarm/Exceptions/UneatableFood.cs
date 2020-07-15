using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Exceptions
{
    public class UneatableFood : Exception
    {
      
       

        public UneatableFood(string message) 
            : base(message)
        {
        }
    }
}
