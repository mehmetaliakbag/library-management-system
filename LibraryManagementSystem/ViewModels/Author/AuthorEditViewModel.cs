using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.ViewModels.Author
{
    // Represents the view model for editing an existing author
    public class AuthorEditViewModel
    {
        // Unique identifier of the author
        public int Id { get; set; }

        // First name of the author
        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "'{0}' field is required.")] // The first name field is required.
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 5 and 100 characters.")] // The first name must be between 1 and 100 characters.
        public string FirstName { get; set; } = "";

        // Last name of the author
        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "'{0}' field is required.")] // The last name field is required.
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 5 and 100 characters.")] // The last name must be between 1 and 100 characters.
        public string LastName { get; set; } = "";

        // Date of birth of the author
        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "'{0}' field is required.")] // The date of birth field is required.
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    }
}
