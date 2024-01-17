namespace Notifier;

internal interface INotificationService
{
    public void Notify(string sender, string receiver, string message) =>
        Console.WriteLine($"LOG: From: {sender} -> To: {receiver}, Message: {message}");
}

public sealed class PushNotificationProvider : INotificationService
{
    public void Notify(string sender, string receiver, string message)
    {

    }
}

public sealed class SMSNotificationProvider : INotificationService
{
    public void Notify(string sender, string receiver, string message)
    {

    }
}

public sealed class EmailNotificationProvider : INotificationService
{
    public void Notify(string sender, string receiver, string message)
    {

    }
}
