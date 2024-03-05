using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT2
{
    class Truck:Vehicle
    {
        public string Company { set; get; }   //Cong ty quan ly
        public string Load { set; get; }   //Trong tai
        public string Cargo { set; get; }    //Hang hoa
        public string Fuel { set; get; } //Nhien lieu

        public Truck()
        {
        }

        public Truck(string make, string model, string year, double price, string company, string load, string cargo, string fuel) : base(make, model, year, price)
        {
            Company = company;
            Load = load;
            Cargo = cargo;
            Fuel = fuel;
        }

      

    }
}
