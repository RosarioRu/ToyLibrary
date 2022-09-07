using System.ComponentModel.DataAnnotations;

namespace ToyLibrary.Models
{
  public class Toy
  {
    public int ToyId {get; set;}

    [Required]
    [StringLength(40)]
    public string Name {get; set;}

    [Required]
    public string Description {get; set;}

    [Required]
    [Range(0,17, ErrorMessage = "Minimum age must be between 0 and 17.")]
    public int UserAgeMinimum {get; set;}

    [Required]
    [Range(0,17, ErrorMessage = "Maximum age must be between 0 and 17.")]
    public int UserAgeMaximum {get; set;}
  }
}