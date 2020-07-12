﻿using P03.ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProduct();

            string cmd;
            while ((cmd=Console.ReadLine())!="END")
            {
                var cmdArg = cmd.Split().ToArray();
                var personName = cmdArg[0];
                var productName = cmdArg[1];

                try
                {
                    var person = people.First(p => p.Name == personName);
                    var product = products.First(p => p.Name == productName);
                    person.BuyProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }

            }

            foreach (var person in this.people)
            {
                Console.WriteLine(person); 
            }

        }

        private void AddProduct()
        {
            var productArgs = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < productArgs.Length; i++)
            {
                var currProduct = productArgs[i]
                    .Split('=')
                    .ToArray();
                var name = currProduct[0];
                var cost = decimal.Parse(currProduct[1]);
                var product = new Product(name, cost);
                products.Add(product);
            }
        }

        private void AddPeople()
        {
            var peopleArgs = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < peopleArgs.Length; i++)
            {
                var currPeopletokens = peopleArgs[i]
                    .Split('=')
                    .ToArray();
                var name = currPeopletokens[0];
                var money = decimal.Parse(currPeopletokens[1]);
                var person = new Person(name, money);
                this.people.Add(person);
            }
        }
    }
}

