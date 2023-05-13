using Microsoft.EntityFrameworkCore;
using Payments.Domains;

namespace Payments.Data
{
    public class PaymentsDbContext : DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> options) : base(options)
        {

        }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Payment>().HasData
                (
               new Payment { Id = "ef9032fc-d106-412f-9b7a-09b902db7dfz", UserId = "ef9632fc-d406-412f-9b7a-09b902db6dfa", Amount = 25.80m, Type = PaymentType.Cash },
               new Payment { Id = "ef9032fc-e106-412f-9b7a-0zb9x2db7df6", UserId = "ef9632fc-d406-412f-9b7a-09b902db6dfa", Amount = 125.80m, Type = PaymentType.Paycard }
                );
        }
    }
}
