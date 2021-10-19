using System.Threading;
using CallsThreads;
using HW3_Task;

namespace CallsThreads
{
    public class ThreadArgs
    {
            public Call Call { get; init; }

            public CancellationToken Token { get; init; }

            public int Count { get; set; }
    }
}
