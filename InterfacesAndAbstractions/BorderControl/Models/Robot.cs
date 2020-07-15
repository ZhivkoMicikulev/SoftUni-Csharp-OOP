using P04.BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl.Models
{
    public class Robot : IModel, IId
    {
        public Robot(string id,string model)
        {
            this.Id = id;
            this.Model = model;
        }
      
        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}
