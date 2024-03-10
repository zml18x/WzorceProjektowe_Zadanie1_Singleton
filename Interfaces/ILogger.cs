namespace SingletonZad1.Interfaces
{
    public interface ILogger
    {
        public string? Log(string? message);
        public LinkedList<ILog> GetLogs();
    }
}