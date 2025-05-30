using Microsoft.AspNetCore.Mvc;
using NotificationServiceClass = Ventixe.NotificationService.Services.NotificationService;

namespace Ventixe.NotificationService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : Controller
{
    private readonly NotificationServiceClass _notificationService;
    private readonly ILogger<NotificationsController> _logger;

    public NotificationsController(NotificationServiceClass notificationService, ILogger<NotificationsController> logger)
    {
        _notificationService = notificationService;
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Notify([FromBody] int eventId)
    {
        _logger.LogInformation("📥 POST /api/notifications reached with eventId: {EventId}", eventId);
        _notificationService.SendNotification(eventId);
        return Ok();
    }
}
