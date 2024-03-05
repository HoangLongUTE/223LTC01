using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT2
{
    class Car : Vehicle
    {
        public string Color { set; get; }   //Mau sac
        public int Seats { set; get; }   //So ghe
        public string LicensePlate { set; get; }    //Bien so xe
        public string Mileage { set; get; } //So km da di

        public Car()
        {
        }

        public Car(string make, string model, string year, double price, string color, int seats, string licensePlate, string mileage) : base(make, model, year, price)
        {
            Color = color;
            Seats = seats;
            LicensePlate = licensePlate;
            Mileage = mileage;
        }

        


    }
}
