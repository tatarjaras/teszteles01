using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles01
{
    internal class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Tax { get; set; }

        public Car(string brand, string model, int year, int tax)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Tax = tax;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Tax} Ft";
        }
    }
}
