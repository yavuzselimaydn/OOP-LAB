using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Truck : Vehicle
    {
        private int _numberOfWheel;
        public override int NumberOfWheel 
        {
            get => _numberOfWheel;
            set
            {
                if (_numberOfWheel <= 12)
                {
                    _numberOfWheel = value;
                }
                else
                    throw new Exception("Invalid value.");
            }
        }

        public Truck() {}
        public Truck(double engine, string model, int numberOfWheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}
