using System.Xml.Serialization;

namespace Ventixe.NotificationService.Services;

public class NotificationService
{
    private readonly ILogger<NotificationService> _logger;

    public NotificationService(ILogger<NotificationService> logger)
    {
        _logger = logger;
    }

    public void SendNotification(int eventId)
    {
        var message = $"Notification sent for booking of event {eventId} at {DateTime.UtcNow}";
        Console.WriteLine(message); 
    }
}
