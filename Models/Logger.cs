using SingletonZad1.Interfaces;

namespace SingletonZad1.Models
{
    public class Logger : ILogger
    {
        private static ILogger? _logger;
        private LinkedList<ILog> _logs;
        private static readonly object _lock = new object();



        private Logger()
        { 
            _logs = new LinkedList<ILog>();
        }


        public static ILogger GetLogger()
        {
            lock (_lock)
                return _logger == null ? _logger = new Logger() : _logger;
        }

        

        public string Log(string? message)
        {
            try
            {
                var log = new Log(Guid.NewGuid(), DateTime.UtcNow, message);
                _logs.AddLast(log);

                return $"{log.TimeStamp} || {log.Message}";
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while creating the log. Error message: {ex.Message}");
            }          
        }

        public LinkedList<ILog> GetLogs()
            => _logs;
    }
}