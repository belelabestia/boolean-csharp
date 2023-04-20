namespace MyFirstBlog.Logging
{
    public class CustomGeneralLogger : ICustomLogger
    {
        CustomFileLogger _fileLogger;
        CustomConsoleLogger _consoleLogger;

        public CustomGeneralLogger(CustomFileLogger fileLogger, CustomConsoleLogger consoleLogger)
        {
            _fileLogger = fileLogger;
            _consoleLogger = consoleLogger;
        }

        public void WriteLog(string message)
        {
            _fileLogger.WriteLog(message);
            _consoleLogger.WriteLog(message);
        }
    }
}
