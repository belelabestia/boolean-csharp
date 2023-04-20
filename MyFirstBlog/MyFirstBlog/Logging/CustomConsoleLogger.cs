namespace MyFirstBlog.Logging
{
    public class CustomConsoleLogger : ICustomLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("LOG MESSAGE: " + message);
        }
    }
}
