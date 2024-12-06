using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.ViewModels.Author
{
    // Represents the view model for creating a new author
    public class AuthorCreateViewModel
    {
        // First name of the author
        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "'{0}' field is required.")] // "{0}" field is required.
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 1 and 100 characters.")] // The field must be between 1 and 100 characters.
        public string FirstName { get; set; } = "";

        // Last name of the author
        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "'{0}' field is required.")] // "{0}" field is required.
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 1 and 100 characters.")] // The field must be between 1 and 100 characters.
        public string LastName { get; set; } = "";

        // Date of birth of the author
        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "'{0}' field is required.")] // "{0}" field is required.
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    }
}
