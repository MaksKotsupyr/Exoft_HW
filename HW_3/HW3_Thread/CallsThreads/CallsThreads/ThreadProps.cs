using System.Threading;
using CallsThreads;
using HW3_Task;

namespace CallsThreads
{
    public class ThreadProps
    {
            public Call Call { get; set; }

            public CancellationToken Token { get; set; }

            public int Count { get; set; }
    }
}
