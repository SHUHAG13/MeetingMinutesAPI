using MeetingMinutesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<ProductService> Products { get; set; }
        public DbSet<MeetingMinutesMaster> MeetingMinutesMasters { get; set; }
        public DbSet<MeetingMinutesDetails> MeetingMinutesDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MeetingMinutesDetails>()
               .HasOne(d => d.Master)
               .WithMany(m => m.Details)
               .HasForeignKey(d => d.MasterId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
