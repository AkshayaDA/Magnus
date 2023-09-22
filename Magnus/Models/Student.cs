using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    [Required(ErrorMessage = "Username is required")]


    // public int Id { get; set; }
    public string Username { get; set; }
    [Required(ErrorMessage = "First Name is required.")]
    [StringLength(50, ErrorMessage = "First Name must be less than or equal to 50 characters.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required.")]
    [StringLength(50, ErrorMessage = "Last Name must be less than or equal to 50 characters.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Mobile No is required.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile No must be a 10-digit number.")]
    public string MobileNo { get; set; }

    [Required(ErrorMessage = "Email Id is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string EmailId { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Birth Date is required.")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    public string Country { get; set; }

    [Required(ErrorMessage = "City is required.")]
    public string City { get; set; }
}
