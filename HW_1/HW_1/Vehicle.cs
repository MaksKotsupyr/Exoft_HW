using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class Vehicle
    {
        public Vehicle(string brand, int year, int price, int seatsNumber)
        {
            Brand = brand;
            Year = year;
            Price = price;
            SeatsNumber = seatsNumber;
        }
        public static int count = 0;
        public string brand;
        public int year;
        public int price;    
        public int seatsNumber;

        public string Brand
        {
            get;
        }
        public int Year
        {
            get;
        }
        public int Price
        {
            get;
        }
        public int SeatsNumber
        {
            get;
        }

        public override string ToString()
        {
            return $"{Brand}-{Year}, price-{Price}$";
        }
    }
}
