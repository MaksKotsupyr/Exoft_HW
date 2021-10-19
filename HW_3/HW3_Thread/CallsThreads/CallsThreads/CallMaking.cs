using CallsThreads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW3_Task
{
    public static class CallMaking
    {
        public static void ManageCallThread(object obj)
        {
            int count = ((ThreadArgs)obj).Count;
            Call call = ((ThreadArgs)obj).Call;
            CancellationToken token = ((ThreadArgs)obj).Token;

            call.Status = CallStatus.InProgress;
            Console.WriteLine($"Thread[{count}] Phonenumber[{call.PhoneNumber}] {call.Status} - wait {call.Duration / 1000}s");

            lock (call)
            {
                Monitor.Wait(call, call.Duration);

                if (token.IsCancellationRequested)
                {
                    call.Status = CallStatus.Cancelled;
                    Console.WriteLine($"{call.PhoneNumber} {call.Status}");
                }
            }

            call.Status = CallStatus.Finished;
            Console.WriteLine($"{call.PhoneNumber} {call.Status}");
        }

    }
}
