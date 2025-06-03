using Microsoft.EntityFrameworkCore;
using Ventixe.NotificationService.Models;

namespace Ventixe.NotificationService.Data;

public class NotificationDbContext: DbContext
{
    public NotificationDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Notification> Notifications => Set<Notification>();
}
