using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P1
{
    internal class Timing
    {
        TimeSpan Duration;
        TimeSpan[] Threads;
        public Timing()
        {
            Duration = new TimeSpan();
            Threads = new TimeSpan[Process.GetCurrentProcess().Threads.Count];
        }
        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            for (int p = 0; p < Threads.Length; p++)
                Threads[p] = Process.GetCurrentProcess().Threads[p].UserProcessorTime;
        }
        public void StopTime()
        {
            TimeSpan tmp;
            for (int p = 0; p < Threads.Length; p++)
            {
                tmp = Process.GetCurrentProcess().Threads[p].UserProcessorTime.Subtract(Threads[p]);
                if (tmp > TimeSpan.Zero)
                    Duration = tmp;
            }
        }
        public TimeSpan Result()
        {
            return Duration;
        }
    }
}
