using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TAika
{
    /// <summary>
    /// This Random is Seriously Random.
    /// </summary>
    public static class SeriouslyRandom
    {
        /// <summary>
        /// Holds the current seed value.
        /// </summary>
        private static int seed = Environment.TickCount;

        /// <summary>
        /// Holds a separate instance of Random per thread.
        /// </summary>
        /// 
        private static readonly ThreadLocal<Random> random =
        new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        /// <summary>
        /// Returns a Seriously Random value.
        /// </summary>
        public static int Next(int minValue, int maxValue)
        {
            return random.Value.Next(minValue, maxValue);
        }
    }
}
