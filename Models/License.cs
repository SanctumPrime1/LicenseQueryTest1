namespace LicenseQueryTest.Models;

internal class License
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; } = null!;
    public string FacilityName { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
