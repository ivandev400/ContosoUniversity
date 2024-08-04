using ContosoUniversity.Models;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Controllers.ViewModels
{
    public class InstructorViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string OfficeAssignmentLocation { get; set; }
    }
}
