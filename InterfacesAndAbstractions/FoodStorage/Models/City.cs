using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage.Models
{
  public  class City
    {
       private List<Rebel> rebels;
        private List<Citizen> citizens;
        public City()
        {
            this.rebels = new List<Rebel>();
            this.citizens = new List<Citizen>();
        }

        public IReadOnlyCollection<Rebel> Rebels => this.rebels;
        public IReadOnlyCollection<Citizen> Citizens => this.citizens;

        public void AddRebel(Rebel rebel)
        {
            this.rebels.Add(rebel);
        }
        public void AddCitizen  (Citizen citizen)
        {
            this.citizens.Add(citizen);
        }

    }
}
