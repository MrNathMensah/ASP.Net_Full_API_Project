using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondProject.Models
{
    public class Student
    {
        [Key]
        //[ScaffoldColumn(false)]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Please type First Name")]
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "The length of the First Name is too long")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please type Middle Name")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Please type Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please type Age")]
        public string? Age { get; set; }

        [Required(ErrorMessage = "Please type Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Please type Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Please supply Email")]
        public string? EmailAddress { get; set; }
        public string? NextOfking { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        [ForeignKey("ProgrammeID")]
        public int ProgrammeID { get; set; }
        public Programme Programme { get; set; } = default!;

    }

    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Range(100, 1000, ErrorMessage = "Please type the amount between the range")]
        public double AmountPaid { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; } = default!;
    }

    public class Programme
    {
        [Key]
        public int ProgrammeID { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Year { get; set; }
        public double Amount { get; set; }
        public DateTime StartDate { get; set; }



    }

}
