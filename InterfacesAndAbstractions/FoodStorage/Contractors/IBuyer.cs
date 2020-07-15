using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage.Contractors
{
   public interface IBuyer
    {
        int BuyedFood { get; }
        void BuyFood();
        
    }
}
