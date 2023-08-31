using LicenseQueryTest;
using Microsoft.EntityFrameworkCore;

//TODO: Fix the bug causing the licenses to not print out

//Setup the database
var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlite("Filename=Database.db");

await using var dbContext = new ApplicationDbContext(optionsBuilder.Options);
await dbContext.Database.EnsureCreatedAsync();

//Print all users from the database followed by their licenses
var users = await dbContext.Users.ToListAsync();
foreach (var user in users)
{
    Console.WriteLine($"{user.FirstName} {user.LastName}");

    foreach (var license in user.Licenses)
    {
        Console.WriteLine($"#{license.LicenseNumber} - {license.FacilityName} ");
    }

    Console.WriteLine("");
}
