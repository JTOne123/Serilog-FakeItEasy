namespace SerilogFakeItEasy
{
    /// <summary>
    /// This class was created to compensate for some tribal knowledge. When testing with FakeItEasy and wanting to make sure
    /// logging was called with the appropriate messages given the logic we noticed the mocking/faking becomes very different
    /// whether you use Log.Information vs Log.Logger.Information.
    ///
    /// If your team deviates from Log.Information standard and uses Log.Logger.Information you need to Fake different methods.
    /// This information is only known if you go to the source on GitHub.
    /// 
    /// Log.Information requires you to Fake method(s) called .Write(). Whereas Log.Logger.Information requires to Fake Method(s) .Information()
    /// </summary>
    public static class FakeLogger
    {
        public static IFakeLogWriter FakeInformation => new InformationToLogger();

        public static IFakeLogWriter FakeWarning => new WarningToLogger();

        public static IFakeLogWriter FakeDebug => new DebugToLogger();

        public static IFakeLogWriter FakeError => new ErrorToLogger();

        public static IFakeLogWriter FakeFatel => new FatalToLogger();

        public static IFakeLogWriter FakeVerbose => new VerboseToLogger();

        public static void Clear()
        {
            WriterToLogger.Clear();
        }

    }
}
