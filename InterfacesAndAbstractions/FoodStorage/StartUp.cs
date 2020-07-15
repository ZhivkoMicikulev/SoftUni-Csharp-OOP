using FoodStorage.Core;
using System;

namespace FoodStorage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}
