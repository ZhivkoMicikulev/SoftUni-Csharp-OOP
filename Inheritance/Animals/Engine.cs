using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Engine
    {
        private readonly List<Animal> animals;
        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "Beast!")
            {
                var animalArg = Console.ReadLine().Split().ToArray();
                Animal animal;
                try
                {
                     animal = GetAnimal(cmd, animalArg);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                this.animals.Add(animal);

            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }

        private static string GetGender(string[] animalArg)
        {
            string gender = null;
            if (animalArg.Length >= 3)
            {
                gender = animalArg[2];
            }

            return gender;
        }

        private Animal GetAnimal(string cmd, string[] animalArg)
        {
            var name = animalArg[0];
            var age = int.Parse(animalArg[1]);
            string gender = GetGender(animalArg);
            Animal animal = null;
            if (cmd == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (cmd == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (cmd == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (cmd == "Kitten")
            {

                animal = new Kitten(name, age);
            }
            else if (cmd == "Tomcat")
            {

                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            return animal;
        }

    }
}
