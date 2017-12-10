### Sample Tests
Sample tests are writen against the SampleCoreWebApi project. The purpose of these test samples is to show how to use the Fake Loggers to verify Logging.


##### Information Logging Tests
Information logging will not included exceptions messages, so it can be verifyied 
as a one to one match. see below. 

```c#

// GET api/values
[HttpGet]
public IEnumerable<ValueEntity> Get()
{
    Log.Information("Get list of values");
    return MockValueData.GetValues();
}

//Test of Get Values from ValuesController
[TestMethod]
public void TestGetSuccess()
{
    var getInfo = FakeLogger.FakeInformation.Write("Get list of values");
    var list = controller.Get().ToList();

    list.Should().NotBeNull();
    list.Count.ShouldBeEquivalentTo(5);
    A.CallTo(getInfo).MustHaveHappened(Repeated.Exactly.Once);
}
```

##### Error Logging Tests
Error or Fatal logging includes the exception in the message. Serilog will display the exception
message along with the Stack Trace from the point of the exception. This makes testing a match dificult. 
When testing logging in these cases it is recommended to use the `WithAnyArguments` extention method.

```c#
 // GET api/values/5
[HttpGet("{id}")]
public ValueEntity Get(int id)
{
    ValueEntity valueEntity = null;
    try
    {
        Log.Information("Get Value by Id [{Id}]", id);
        valueEntity = MockValueData.GetValues().Single(a => a.Id == id);
    }
    catch (Exception exception)
    {
        //logs exception message
        LogException(exception);
    }

    return valueEntity;
}

//Test of Get/id value from ValuesController
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

```