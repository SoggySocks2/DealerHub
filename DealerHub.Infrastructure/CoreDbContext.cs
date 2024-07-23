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
    }
}
