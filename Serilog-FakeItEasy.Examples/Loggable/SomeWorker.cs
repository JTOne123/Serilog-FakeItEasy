using System;
using System.Threading;
using Serilog;

namespace SerilogFakeItEasy.Examples.Loggable
{
    public class SomeWorker
    {
        /// <summary>
        /// This is just a regular methods with information logging.
        /// </summary>
        public int JustLog()
        {
            Log.Information("Starting some kind of process...");

            var accumulator = 0;
            for (var i = 0; i < 5; i++)
            {
                accumulator++;
                Thread.Sleep(1000);
            }

            Log.Information("Process ended!");

            return accumulator;
        }

        /// <summary>
        /// Attempts to do something then errors out.
        /// </summary>
        /// <returns></returns>
        public int JustLogWithError()
        {
            Log.Information("Starting some kind of process...");

            var accumulator = 0;

            for (var i = 0; i < 5; i++)
            {
                accumulator++;
                switch (i)
                {
                    case 0:
                        Log.Information("Count is [{Accumulator}].", accumulator);
                        break;
                    case 1:
                        Log.Information("Count is [{Accumulator}].", accumulator);
                        break;
                    case 2:
                        Log.Warning("Number is getting too big. [{Accumulator}].", accumulator);
                        break;
                    case 3:
                        Log.Warning("Last warning.....tooo high [{Accumulator}].", accumulator);
                        break;
                    case 4:
                        Log.Error("[{Accumulator}] -> That's it I'm aslpoding........ahhhhhhhhhhhhhhh boom!", accumulator);
                        throw new Exception("I asploded!");
                    default:
                        throw new NotImplementedException("You found a super awesome edge case.");
                }
            }

            Log.Information("Process ended!");
            return accumulator;
        }

        /// <summary>
        /// Same log repeated.
        /// </summary>
        public void SameLogMultipleTimes()
        {
            for(var i = 0; i < 3; i++) { Log.Warning("Repeat!"); }
        }
    }
}
