using MagazynierApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MagazynierApp.Server
{
    public class ApplicationStoreContext: DbContext
    {
        public ApplicationStoreContext(DbContextOptions<ApplicationStoreContext> options):base(options)
        {
            
        }
        
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }
        public DbSet<MachineWarningNotification> MachineWarningNotifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
