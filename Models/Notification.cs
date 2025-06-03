namespace Ventixe.NotificationService.Models;

public class Notification
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
    public string Message { get; set; } = string.Empty;

    public int? UserId { get; set; }
}
