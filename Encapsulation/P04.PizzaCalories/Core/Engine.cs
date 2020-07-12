using P04.PizzaCalories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.PizzaCalories.Core
{
    public class Engine
    {

        public void Run()
        {
			try
			{
                var pizzaArg = Console.ReadLine().Split().ToArray();

                var name = string.Empty;


                name = pizzaArg[1];
                var pizza = new Pizza(name);

                var doughArg = Console.ReadLine().Split().ToArray();
                var floar = doughArg[1];
                var bake = doughArg[2];
                var weight = int.Parse(doughArg[3]);
                var dough = new Dough(floar, bake, weight);
                pizza.Dough = dough;
                string cmd;

                while ((cmd = Console.ReadLine()) != "END")
                {

                    var toppingArg = cmd.Split().ToArray();
                    var type = toppingArg[1];
                    var weightTopping = int.Parse(toppingArg[2]);
                    var topping = new Topping(type, weightTopping);
                    pizza.AddTopping(topping);



                }
                Console.WriteLine(pizza);
            }
			catch (ArgumentException ae)
			{

                Console.WriteLine(ae.Message);
			}
        }






    }

}


