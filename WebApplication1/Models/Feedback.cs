using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment number is required")]
        [Display(Name = "Enrollment Number")]
        public string? Enrollmentnum { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be 2 to 50 characters")]
        [Display(Name = "Student Name")]
        public string? StudentName { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string? Subject { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(500, ErrorMessage = "Comments can be at most 500 characters")]
        public string? Comments { get; set; }
    }
}