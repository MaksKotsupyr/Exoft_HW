using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HW3_Task
{
    class Program
    {
        static void Main()
        {
            int count = 1;
            var tokens = new List<CancellationTokenSource>();
            var callList = new List<Call>
            {
                new Call(9000, 2340),
                new Call(7000, 2345),
                new Call(9000, 2221),
                new Call(9000, 2329),
                new Call(5000, 9934),
                new Call(4000, 5614),
                new Call(6000, 9901),
                new Call(10000, 1002),
                new Call(7000, 3032)
            };
            Console.WriteLine("CallList:");
            foreach (var call in callList)
            {
                Console.WriteLine($"{call}");
            }
            Console.WriteLine("To start call write 'call'| |To cancel call write 'cancel'| |To see call history 'log'");
            while (true)
            {
                string inputValue = Console.ReadLine();
                if (inputValue == "call")
                {
                    Console.WriteLine("To start call write 'phonenumber'");
                    string inputNumber = Console.ReadLine();
                    foreach (var call in callList)
                    {
                        if (inputNumber == $"{call.PhoneNumber}")
                        {
                            if (call.Status == CallStatus.NotStart)
                            {
                                var cts = new CancellationTokenSource();
                                var token = cts.Token;
                                tokens.Add(cts);
                                var task = CallMaking.CallAsync(call, token, count++);
                            }
                            else
                            {
                                Console.WriteLine("Call just in progress or finished");
                            }
                        }
                    }

                }
                else if (inputValue == "cancel")
                {
                    Console.WriteLine("To cancel call write 'ID' of call");
                    string idNumber = Console.ReadLine();
                    if(tokens.Count <= 0)
                    {
                        Console.WriteLine("Not active calls");
                    }
                    foreach (var call in callList)
                    {
                        if (call.Status == CallStatus.InProgress && Int32.TryParse(idNumber, out int IdCall) && tokens.Count > 1)
                        {
                            tokens[IdCall - 1].Cancel();
                            tokens[IdCall - 1].Dispose();
                        }
                    }
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
