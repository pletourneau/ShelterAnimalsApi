using System.ComponentModel.DataAnnotations;

namespace ShelterAnimalsApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [StringLength(20)]

    public string Name { get; set; }

    [Required]
    [StringLength(20)]

    public string Species { get; set; }

    [Required]
    [StringLength(20)]

    public string Breed { get; set; }

    [Required]
    [Range(0, 50)]

    public int? Age { get; set; }
  }
}