using P03.ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace P03.ShoppingSpree.Models
{
    public class Person
    {
        private const decimal COST_MIN_VALUE = 0m;
        private string name;
        private decimal money;
        private List<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (GlobalConstant.InvalidNameExceptionMessage);
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value<COST_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstant.InvalidCostExceptionMessage);
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly();

        public void BuyProduct(Product product)
        {
            if (this.Money<product.Cost)
            {
                throw new InvalidOperationException
                    (string.Format
                    (GlobalConstant.InsufficientExceptionMoney, this.Name, product.Name));
            }
            this.Money -= product.Cost;
            this.bag.Add(product);
        }

        public override string ToString()
        {
            var productsOutput = this.bag.Count > 0 ? string.Join(", ", this.bag)
                : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}
