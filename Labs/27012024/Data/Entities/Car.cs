using System.ComponentModel.DataAnnotations;

public class Car
{
    [Required]
    public string Id { get; init; } = Guid.NewGuid().ToString();
    [Required]
    public string Model { get; set; }
    [Required]
    public string Color { get; set; }
}