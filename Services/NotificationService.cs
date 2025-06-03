using System.Xml.Serialization;
using Ventixe.NotificationService.Data;
using Ventixe.NotificationService.Models;

namespace Ventixe.NotificationService.Services;

public class NotificationService
{
    private readonly NotificationDbContext _context;
    private readonly ILogger<NotificationService> _logger;

    public NotificationService(NotificationDbContext context, ILogger<NotificationService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<Notification> SendNotificationAsync(int eventId, int? userId = null)
    {
        var notification = new Notification
        {
            EventId = eventId,
            UserId = userId,
            Message = $"📣 Event {eventId} has been booked at {DateTime.UtcNow}"
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();

        _logger.LogInformation($"Notification stored for EventId: {eventId}");

        return notification;
    }

    public IEnumerable<Notification> GetAllNotifications() => _context.Notifications.OrderByDescending(n => n.SentAt).ToList();
}
