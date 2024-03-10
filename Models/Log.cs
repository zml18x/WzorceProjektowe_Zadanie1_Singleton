using SingletonZad1.Interfaces;

namespace SingletonZad1.Models
{
    public class Log : ILog
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Message { get; set; }



        public Log(Guid id, DateTime timeStamp, string? message)
        {
            Id = id;
            TimeStamp = timeStamp;
            Message = LogMessageValidate(message);
        }



        private string LogMessageValidate(string? logMessage)
        {
            if(string.IsNullOrEmpty(logMessage))
                throw new ArgumentNullException(nameof(logMessage),"Message cannot be null");

            return logMessage;
        }
    }
}