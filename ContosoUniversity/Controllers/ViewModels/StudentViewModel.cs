using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Controllers.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
