using DealerHub.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DealerHub.Infrastructure;
public class CoreDbContext : DbContext
{
    public DbSet<Dealer> Dealers { get; set; }
    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ApplyConfiguration(modelBuilder);
    }
    private static void ApplyConfiguration(ModelBuilder modelBuilder)
    {
        ApplyConfigurationForDealer(modelBuilder.Entity<Dealer>());
    }
    private static void ApplyConfigurationForDealer(EntityTypeBuilder<Dealer> entity)
    {
        entity.ToTable("sysDealer");
        entity.HasKey(p => p.Id);
        entity.Property(p => p.Id).ValueGeneratedOnAdd();

        entity.Property(p => p.Name).HasMaxLength(100).IsRequired();
        entity.OwnsOne(x => x.Address, cb =>
        {
            cb.Property(p => p.AddressLine1).HasMaxLength(100).IsRequired();
            cb.Property(p => p.AddressLine2).HasMaxLength(100).IsRequired();
            cb.Property(p => p.AddressLine3).HasMaxLength(100).IsRequired();
            cb.Property(p => p.PostCode).HasMaxLength(10).IsRequired();
        });
        entity.OwnsOne(x => x.ContactInfo, cb =>
        {
            cb.Property(p => p.HomeTelNo).HasMaxLength(20).IsRequired();
            cb.Property(p => p.MobileTelNo).HasMaxLength(20).IsRequired();
            cb.Property(p => p.EmailAddress).HasMaxLength(100).IsRequired();
        });
    }
}
