namespace MyFirstBlog.Logging
{
    public class CustomFileLogger : ICustomLogger
    {
        public void WriteLog(string message)
        {
            File.AppendAllText("log.txt", "LOG MESSAGE: " + message + Environment.NewLine);
        }
    }
}
