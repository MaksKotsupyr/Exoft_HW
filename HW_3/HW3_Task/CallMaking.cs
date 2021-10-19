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
        public static async Task CallAsync(Call call, CancellationToken token, int count)
        {
            try
            {
                call.Status = CallStatus.InProgress;
                Console.WriteLine($"ID[{count}] Phonenumber[{call.PhoneNumber}] {call.Status} - wait {call.Duration/1000}s");

                await Task.Delay(call.Duration, token);

                call.Status = CallStatus.Finished;
                Console.WriteLine($"{call.PhoneNumber} {call.Status}");
            }
            catch (TaskCanceledException)
            {
                call.Status = CallStatus.Cancelled;
                Console.WriteLine($"{call.PhoneNumber} {call.Status}");
            }
        }

    }
}
