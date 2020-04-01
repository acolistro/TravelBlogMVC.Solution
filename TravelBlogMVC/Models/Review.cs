using System.ComponentModel.DataAnnotations;

namespace TravelBlogMVC.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [StringLength(2000)]
    public string Description { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "You cannot exceed 5 stars, relax!")]
    public int Rating { get; set; }
    [Required]
    public int DestinationId { get; set; }
    // [Required]
    // public virtual Destination Destination { get; set; }
  }
}