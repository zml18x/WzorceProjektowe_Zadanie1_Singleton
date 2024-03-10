namespace SingletonZad1.Interfaces
{
    public interface ILog
    {
        Guid Id { get; set; }
        DateTime TimeStamp { get; set; }
        string? Message { get; set; }
    }
}
