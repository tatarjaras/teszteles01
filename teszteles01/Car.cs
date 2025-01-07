using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles01
{
    public class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Tax
        {
            get
            {
                if (DateTime.Today.Year-Year<10)
                {
                    return 20000;
                }
                else if (DateTime.Today.Year-Year<=30)
                {
                    return 10000;
                }
                else 
                {
                    return 0;
                }
            } }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Tax} Ft";
        }

        public bool Isveterane()
        {
            return DateTime.Today.Year - Year > 30;
        }
    }
}
