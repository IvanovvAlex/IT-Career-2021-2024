using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    [Required]
    public string Id { get; init; } = Guid.NewGuid().ToString();

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }
}