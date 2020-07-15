using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Core.Contracts;
using WildFarm.Exceptions;
using WildFarm.Factorys;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;
        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.foodFactory = new FoodFactory();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var animalArg = command
                    .Split()
                    .ToArray();
                var foodArg = Console.ReadLine()
                                    .Split()
                                    .ToArray();
                var animalType = animalArg[0];
                var name = animalArg[1];
                var weight = double.Parse(animalArg[2]);
                IAnimal animal = ProduceAnimal(animalArg, animalType, name, weight);
                IFood food = this.foodFactory.ProduceFood(foodArg[0], int.Parse(foodArg[1]));
                this.animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Feed(food);
                }
                catch (UneatableFood ufe)
                {

                    Console.WriteLine(ufe.Message);
                }

            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string[] animalArg, string animalType, string name, double weight)
        {
            IAnimal animal = null;

            if (animalType == "Owl")
            {

                var wingSize = double.Parse(animalArg[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {

                var wingSize = double.Parse(animalArg[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                var livingRegion = animalArg[3];
                if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    var breed = animalArg[4];

                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }

            }

            return animal;
        }
    }
}
