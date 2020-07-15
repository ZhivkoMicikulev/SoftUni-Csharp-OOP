using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;
using Telephony.Exeptions;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private StationaryPhone stationaryphone;
        private Smartphone smartphone;
       
        private Engine()
        {
            this.stationaryphone = new StationaryPhone();
            this.smartphone = new Smartphone();

        }

        public Engine(IReader reader,IWriter writer)
            :this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            var phoneNumbs = reader.ReadLine()
                    .Split()
                    .ToArray();

            var sites = reader.ReadLine()
                .Split()
                .ToArray();

            CallNumber(phoneNumbs);

            BrowseSites(sites);
        }

        private void BrowseSites(string[] sites)
        {
            foreach (var url in sites)
            {
                try
                {
                    writer.WriteLine(smartphone.Browse(url));

                }
                catch (InvalidUrlException iue)
                {

                    writer.WriteLine(iue.Message);
                }
            }
        }

        private void CallNumber(string[] phoneNumbs)
        {
            foreach (var number in phoneNumbs)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        writer.WriteLine(stationaryphone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        writer.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidNumberExceptions();
                    }
                }
                catch (InvalidNumberExceptions ine)
                {

                    writer.WriteLine(ine.Message);
                }

            }
        }
    }
}
