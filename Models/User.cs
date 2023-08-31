namespace LicenseQueryTest.Models;

internal class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }

    public IEnumerable<License> Licenses { get; set; } = new List<License>();
}
