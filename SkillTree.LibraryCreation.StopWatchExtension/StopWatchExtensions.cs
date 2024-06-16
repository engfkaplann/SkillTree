using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.LibraryCreation.StopWatchExtension
{
    public static class StopWatchExtensions
    {
        public static double CalculateExecutionTime(this Stopwatch stopwatch, Func<object> function)
        {
            stopwatch.Start();
            function();
            stopwatch.Stop();
            TimeSpan duration = stopwatch.Elapsed;

            stopwatch.Reset();

            return duration.TotalMilliseconds;
        }
    }
}
