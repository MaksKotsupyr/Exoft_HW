using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class DefaultCar : Vehicle
    {
        public DefaultCar(string brand, int year, int price, int seatsNumber)
            : base(brand, year, price, seatsNumber)
        { }
    }
}
