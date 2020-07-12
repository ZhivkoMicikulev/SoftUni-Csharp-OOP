using P04.PizzaCalories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> topings;


        public Pizza()
        {
            this.Toppings = new List<Topping>();
        }
        public Pizza(string name)
            : this()
        {
            this.Name = name;

        }
        public List<Topping> Toppings
        {
            get => this.topings;
            private set
            {
                this.topings = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    value.Length < GlobalConstants.MIN_PIZZA_NAME ||
                    value.Length > GlobalConstants.MAX_PIZZA_NAME)
                {
                    var message = string.Format(GlobalConstants.INVALID_PIZZA_NAME,
                        GlobalConstants.MIN_PIZZA_NAME, GlobalConstants.MAX_PIZZA_NAME);
                    throw new ArgumentException(message);
                }
                this.name = value;
            }

        }

        public Dough Dough
        {
            get => this.dough;
            set
            {
                this.dough = value;
            }
        }

        public double Calories => GetCalories();


        public void AddTopping(Topping topping)
        {
            if (Toppings.Count < GlobalConstants.MIN_PIZZA_TOPPING ||
                Toppings.Count > GlobalConstants.MAX_PIZZA_TOPPING)
            {
                var message = string.Format(GlobalConstants.INVALID_NUMBER_TOPPINGS,
                   GlobalConstants.MIN_PIZZA_TOPPING, GlobalConstants.MAX_PIZZA_TOPPING);
                throw new ArgumentException(message);
            }
            Toppings.Add(topping);
        }

        public double GetCalories()
        {
            var sum = dough.Calories;
            foreach (var topping in Toppings)
            {
                sum += topping.Calories;
            }
            return sum;

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:f2} Calories.";
        }

    }
}
