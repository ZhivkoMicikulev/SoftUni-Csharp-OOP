using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories.Common
{
    public static class GlobalConstants
    {
      
        public static Dictionary<string,double> PizzaCaloriesInfo = new Dictionary<string, double>() 
        { //Floars
            {"White", 1.5 },
            { "Wholegrain",1.0 },
            //Bake
            {"Crispy",0.9 },
            {"Chewy",1.1 },
            {"Homemade",1.0 },
            //Toping
            {"Meat",1.2 },
            {"Veggies",0.8 },
            {"Cheese",1.1 },
            {"Sauce",0.9 }
        };
        public static Dictionary<string, string> PizzaInfo= new Dictionary<string, string>()
        { //Floars
            {"white", "White" },
            { "wholegrain","Wholegrain" },
            //Bake
            {"crispy","Crispy" },
            {"chewy","Chewy" },
            {"homemade","Homemade" },
            //Toping
            {"meat","Meat" },
            {"veggies","Veggies" },
            {"cheese","Cheese" },
            {"sauce","Sauce" }
        };
        //Weights
        public const int WEIGHT_MIN_DOUGH= 1;
        public const int WEIGHT_MAX_DOUGH = 200;
        public const int WEIGHT_MIN_TOPPING = 1;
        public const int WEIGHT_MAX_TOPPING = 50;
        public const int MIN_PIZZA_NAME = 1;
        public const int MAX_PIZZA_NAME = 15;
        public const int MIN_PIZZA_TOPPING = 0;
        public const int MAX_PIZZA_TOPPING = 10;



        //Dough exeption message
        public static string INVALID_DOUGH = "Invalid type of dough.";
        public static string INVALID_WEIGHT = "Dough weight should be in the range [{0}..{1}].";
        public static string INVALID_TOPING = "Cannot place {0} on top of your pizza.";
        public static string INVALID_WEIGHT_TOPPING = "{0} weight should be in the range [{1}..{2}].";
        public static string INVALID_PIZZA_NAME = "Pizza name should be between {0} and {1} symbols.";
        public static string INVALID_NUMBER_TOPPINGS = "Number of toppings should be in range [{0}..{1}].";
    }
}
