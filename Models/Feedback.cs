using System.ComponentModel.DataAnnotations;

namespace feedback1.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter your enrollment number.")]
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; }

        [Range(1, 5, ErrorMessage = "Select a rating from 1 to 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter a comment.")]
        [StringLength(500, ErrorMessage = "Comment must be 500 characters or fewer.")]
        public string Comment { get; set; }
    }
}
