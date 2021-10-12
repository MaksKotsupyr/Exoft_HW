using System;
using System.Collections.Generic;

namespace HW3_Task
{
    class Program
    {
        static void Main()
        {
            int countCalls = 1;
            var callList = new List<Call>
            {
                new Call(4000, 2340),
                new Call(8000, 2345),
                new Call(4000, 2221),
                new Call(4000, 2329),
                new Call(4000, 9934),
                new Call(4000, 5614),
                new Call(4000, 9901),
                new Call(4000, 1002),
                new Call(4000, 3032)
            };
            foreach (var call in callList)
            {
                Console.WriteLine($"{countCalls++}-{call}");
            }
            while (true)
            {
                Console.WriteLine("To start call write 'call'| |To cancel call write 'cancel'| |To see call history 'log'");
                string inputValue = Console.ReadLine();
                if (inputValue == "call")
                {
                    Console.WriteLine("To start call write 'phonenumber'");
                    string inputNumber = Console.ReadLine();
                    //if(inputNumber == call.)
                }
                else if(inputValue == "cancel")
                {
                    Console.WriteLine("To start call write 'phonenumber'");
                    string inputNumber = Console.ReadLine();
                }
                else if (inputValue == "log")
                {
                    foreach (var call in callList)
                    {
                        Console.WriteLine($"PhoneNumber: [{call.PhoneNumber}] {call.Status}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
