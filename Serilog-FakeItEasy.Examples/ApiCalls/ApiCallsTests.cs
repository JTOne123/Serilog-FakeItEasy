using System;
using System.Linq;
using FakeItEasy;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog_FakeItEasy.SampleCoreWebApi.Controllers;

namespace SerilogFakeItEasy.Examples.ApiCalls
{
    [TestClass]
    public class ApiCallsTests
    {
        public ValuesController controller;

        [TestInitialize]
        public void Init()
        {
            controller = new ValuesController();
        }

        [TestMethod]
        public void TestGetSuccess()
        {
            var getInfo = FakeLogger.FakeInformation.Write("Get list of values");
            var list = controller.Get().ToList();

            list.Should().NotBeNull();
            list.Count.ShouldBeEquivalentTo(5);
            A.CallTo(getInfo).MustHaveHappened(Repeated.Exactly.Once);
        }

        [TestMethod]
        public void TestGetByIdSuccess()
        {
            const int id = 5;
            var getInfo = FakeLogger.FakeInformation.Write("Get Value by Id [{Id}]", id);
            var list = controller.Get(id);

            list.Should().NotBeNull();
            list.Value.ShouldAllBeEquivalentTo("Value5");
            A.CallTo(getInfo).MustHaveHappened(Repeated.Exactly.Once);
        }

        [TestMethod]
        public void TestGetByIdException()
        {
            const int id = 6;
            var getInfo = FakeLogger.FakeInformation.Write("Get Value by Id [{Id}]", id);
            var exception = new InvalidOperationException(@"Sequence contains no matching element");
            var getError = FakeLogger.FakeError.Write(exception, "{Message}", exception.Message);

            var list = controller.Get(id);

            list.Should().BeNull();
            A.CallTo(getInfo).MustHaveHappened(Repeated.Exactly.Once);
            A.CallTo(getError).WithAnyArguments().MustHaveHappened(Repeated.Exactly.Once);
        }
    }
}
