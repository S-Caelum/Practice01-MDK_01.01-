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
            for (int i = 0; i < Threads.Length; i++)
                Threads[i] = Process.GetCurrentProcess().Threads[i].UserProcessorTime;
        }
        public void StopTime()
        {
            TimeSpan tmp;
            for (int i = 0; i < Threads.Length; i++)
            {
                tmp = Process.GetCurrentProcess().Threads[i].UserProcessorTime.Subtract(Threads[i]);
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
