using System;

namespace HW_1
{
    class Program
    {
        static void Main()
        {
            var parking = new Parking
            {
                new Motobike("Ducati", 2020, 24000, 2),
                new Truck("SCANIA", 2012, 47400, 8),
                new DefaultCar("Lanos", 2005, 3000, 4),
                new Motobike("BMW", 2010, 31130, 2),
                new Truck("Volvo", 2021, 54405, 8),
                new DefaultCar("Lexus", 2018, 28240, 4)
            };

            parking.ShowAllVehicles();
            parking.Seats();
        }
    }
}
