using System.ComponentModel.DataAnnotations;

namespace ApiProtection.Models;

public class UserModel
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Id { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(10)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(10)]
    public string LastName { get; set; }

    [EmailAddress]
    public string EmailAddress { get; set; }

    [Phone]
    public string PhoneNumber { get; set; }

    [Url]
    public string Homepage { get; set; }

    [Range(0, 5)]
    public int NumberOfVehicles { get; set; }
}
