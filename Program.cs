using SingletonZad1.Models;

var logger1 = Logger.GetLogger();
var logger2 = Logger.GetLogger();

if (logger1 == logger2)
    Console.WriteLine("Correct implementation of the singleton pattern\n\n");
else
    Console.WriteLine("Incorrect implementation of the singleton pattern\n\n");

Console.WriteLine(logger1.Log("Test Log 1"));
Console.WriteLine(logger2.Log("Test Log 2"));

Console.WriteLine("\n");

var logs = logger1.GetLogs();

foreach (var log in logs)
    Console.WriteLine($"ID: {log.Id} || TimeStamp: {log.TimeStamp} || Message: {log.Message}");