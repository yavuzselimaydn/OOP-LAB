using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Vehicle
    {
        private double _engine;
        public virtual double Engine 
        { 
            get => _engine; 
            set
            {
                if (1.0 <= value && value <= 5.0)
                {
                    _engine = value;
                }
                else
                {
                    _engine = 1.0;
                }   
            }
        }
        public virtual string Model { get; set; }
        public virtual int NumberOfWheel { get; set; }
        public virtual int Price { get; set; }
        public virtual string Transmission { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Engine start...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Engine stop...");
        }

        public override string? ToString()
        {
            return $"------------------\n" +
                $"Engine : {Engine}\n" +
                $"Model : {Model}\n" +
                $"NumberOfWheel : {NumberOfWheel}\n" +
                $"Price : {Price}\n" +
                $"Transmission :  {Transmission}\n"+
                $"------------------";
        }
    }
}
