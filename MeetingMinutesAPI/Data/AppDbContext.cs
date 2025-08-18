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
            modelBuilder.Entity<CorporateCustomer>().HasData(
               new CorporateCustomer { CorporateId = 1, Name = "Shuhag" },
               new CorporateCustomer { CorporateId = 2, Name = "Nihal" },
               new CorporateCustomer { CorporateId = 3, Name = "Imran" }
           );
            modelBuilder.Entity<IndividualCustomer>().HasData(
                new IndividualCustomer { IndividualId = 1, Name = "John Doe" },
                new IndividualCustomer { IndividualId = 2, Name = "Jane Smith" },
                new IndividualCustomer { IndividualId = 3, Name = "Alice Johnson" }
            );
            modelBuilder.Entity<ProductService>().HasData(
                 new ProductService { ProductId = 1, Name = "Product A", Unit = "kg" },
                 new ProductService { ProductId = 2, Name = "Product B", Unit = "pcs" },
                 new ProductService { ProductId = 3, Name = "Service C", Unit = "hour" }
             );


            modelBuilder.Entity<MeetingMinutesDetails>()
               .HasOne(d => d.Master)
               .WithMany(m => m.Details)
               .HasForeignKey(d => d.MasterId);


            base.OnModelCreating(modelBuilder);
           
        }
    }
}
