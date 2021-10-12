using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Task
{
    public class Call
    {
        public int Duration { get;}
        public int PhoneNumber { get;}
        public CallStatus Status { get; set;}

        public Call(int time, int phoneNumber)
        {
            Duration = time;
            PhoneNumber = phoneNumber;
            Status = CallStatus.NotStart;
        }
        public override string ToString() =>$"PhoneNumber[{PhoneNumber}]---{Status}";   
    }
}
