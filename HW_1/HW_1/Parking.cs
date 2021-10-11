using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Parking : ICollection<Vehicle>
    {
        public Parking()
        {
            Cars = new();
        }

        List<Vehicle> Cars { get; }
        public int Count => Cars.Count;

        public bool IsReadOnly => false;

        public void Add(Vehicle item)
        {
            Cars.Add(item);
        }

        public void Clear()
        {
            Cars.Clear();
        }

        public bool Contains(Vehicle item)
        {
            return Cars.Contains(item);
        }

        public void CopyTo(Vehicle[] array, int arrayIndex)
        {
            Cars.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public bool Remove(Vehicle item)
        {
            return Cars.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public void ShowAllVehicles()
        {
            int parkingNumber = 1;
            foreach(var vehicle in Cars)
            {
                Console.WriteLine($"Parking number {parkingNumber++}: {vehicle}");
            }
        }

        public int SeatsCount()
        {
            int count = 0;
            foreach (var vehicle in Cars)
            {
                count += vehicle.SeatsNumber;
            }
            return count;
        }
        public void Seats()
        {
            Console.WriteLine($"Total number of seats: {SeatsCount()}");
        }
    }
}
