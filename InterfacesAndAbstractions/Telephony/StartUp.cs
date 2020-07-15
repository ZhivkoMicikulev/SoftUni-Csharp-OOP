using System;
using Telephony.Contracts;
using Telephony.Core;
using Telephony.InputOutput;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
