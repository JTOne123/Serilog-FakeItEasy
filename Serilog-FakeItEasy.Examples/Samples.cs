using System;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerilogFakeItEasy.Examples.Loggable;

namespace SerilogFakeItEasy.Examples
{
    [TestClass]
    public class Samples
    {
        private readonly SomeWorker worker;

        public Samples()
        {
            worker = new SomeWorker();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //Clear any faked calls between tests.
            FakeLogger.Clear();
        }

        [TestMethod]
        public void Simple()
        {
            var startInfoLog = FakeLogger.Information("Starting some kind of process...");
            var endInfoLog = FakeLogger.Information("Process ended!");

            var result = worker.JustLog();

            Assert.AreEqual(5, result);

            A.CallTo(startInfoLog).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(endInfoLog).MustHaveHappened(Repeated.Exactly.Once);
        }

        [TestMethod]
        public void Error()
        {
            var startInfoLog = FakeLogger.Information("Starting some kind of process...");
            var switch1Log = FakeLogger.Information("Count is [1].");
            var switch2Log = FakeLogger.Information("Count is [2].");
            var warning1Log = FakeLogger.Warning("Number is getting too big. [3].");
            var warning2Log = FakeLogger.Warning("Last warning.....tooo high [4].");
            var errorLog = FakeLogger.Error("[5] -> That's it I'm aslpoding........ahhhhhhhhhhhhhhh boom!");

            Assert.ThrowsException<Exception>(() => worker.JustLogWithError(), "I asploded!");
            
            A.CallTo(startInfoLog).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(switch1Log).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(switch2Log).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(warning1Log).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(warning2Log).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(errorLog).MustHaveHappened(Repeated.Exactly.Once);
        }

        [TestMethod]
        public void RepeatedMessages()
        {
            var repeatedWarning = FakeLogger.Warning("Repeat!");

            worker.SameLogMultipleTimes();

            A.CallTo(repeatedWarning).MustHaveHappened(Repeated.Exactly.Times(3));
        }
    }
}
