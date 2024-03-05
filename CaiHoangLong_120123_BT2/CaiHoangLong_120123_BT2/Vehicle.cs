using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT2
{
    class Vehicle
    {
        public string Make { set; get; }    //Hang san xuat
        public string Model { set; get; }   //Mau xe
        public string Year { set; get; }    // Nam san xuat
        public double Price { set; get; }   //Gia ban

        public Vehicle(string make, string model, string year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Vehicle()
        {
        }
    }
}
