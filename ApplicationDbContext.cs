using LicenseQueryTest.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenseQueryTest;

internal class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    public DbSet<License> Licenses { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Miller",
                    DateOfBirth = new DateTime(2000, 6, 15)
                },
                new User
                {
                    Id = 3,
                    FirstName = "Bob",
                    LastName = "Carter",
                    DateOfBirth = new DateTime(2010, 12, 31)
                });
        });

        modelBuilder.Entity<License>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasData(
                new License
                {
                    Id = 1,
                    LicenseNumber = "00001",
                    FacilityName = "Facility 1",
                    UserId = 1
                },
                new License
                {
                    Id = 2,
                    LicenseNumber = "00002",
                    FacilityName = "Facility 2",
                    UserId = 2
                },
                new License
                {
                    Id = 3,
                    LicenseNumber = "00003",
                    FacilityName = "Facility 2",
                    UserId = 1
                });

        });
    }
}
