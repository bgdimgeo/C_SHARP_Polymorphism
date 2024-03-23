using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Interfaces
{
    public interface IAnimalAction
    {
        public string ProduceSound();

        public void Eat(string food,int qty);
    }
}
