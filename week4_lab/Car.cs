using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Car : Vehicle
    {
        public override int NumberOfWheel => 4;
        public Car() {}
        public Car(double engine, string model, int numberOfWheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            _ = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}
