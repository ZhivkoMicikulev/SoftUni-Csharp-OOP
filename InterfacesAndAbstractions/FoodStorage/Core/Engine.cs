using FoodStorage.Contractors;
using FoodStorage.Core.Contracts;
using FoodStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodStorage.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            var city = new City();
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var persons = Console.ReadLine().Split().ToArray();
               
               
                var name = persons[0];
                var age = int.Parse(persons[1]);
                if (persons.Length==4)
                {
                    
                    var birthdate = persons[2];
                    var id = persons[3];
                    Citizen person = new Citizen(name, age,id, birthdate);                    
                    city.AddCitizen(person);
                 
                }
                else if (persons.Length==3)
                {
                    var group = persons[2];
                  Rebel  person = new Rebel(name, age, group);
                   
                    city.AddRebel(person);
                }
               
            }

            string cmd;
           
            while ((cmd=Console.ReadLine())!="End")
            {
                if(city.Citizens.Any(n=>n.Name==cmd))
                {
                    city.Citizens.First(n => n.Name == cmd).BuyFood();
                }
               else if (city.Rebels.Any(n => n.Name == cmd))
                {
                    city.Rebels.First(n => n.Name == cmd).BuyFood();
                }
            }
            var sum = city.Rebels.Sum(f => f.BuyedFood) + city.Citizens.Sum(f => f.BuyedFood);
            Console.WriteLine(sum);

        }
    }
}
