using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.ViewModels.Book
{
    // Represents the view model for creating a new book
    public class BookCreateViewModel
    {
        // Title of the book
        [Display(Name = "Title")]
        [Required(ErrorMessage = "'{0}' field is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 1 and 100 characters.")]
        public string Title { get; set; } = "";

        // Identifier for the author (foreign key)
        [Display(Name = "Author")]
        [Required(ErrorMessage = "'{0}' field is required.")]
        public int AuthorId { get; set; } = 0;

        // Genre of the book
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "'{0}' field is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "'{0}' field must be between 1 and 100 characters.")]
        public string Genre { get; set; } = "";

        // Publication date of the book
        [Display(Name = "Publish Date")]
        [Required(ErrorMessage = "'{0}' field is required.")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.MinValue;

        // ISBN of the book
        [Display(Name = "ISBN")]
        [RegularExpression(@"^\d{3}-\d{1,5}-\d{1,7}-\d{1,7}-\d{1}$", ErrorMessage = "The field must contain a valid ISBN format (XXX-X-XXXXX-XXXXX-X).")] // Valid ISBN format (e.g. 978-3-16-148410-0)
        public string ISBN { get; set; } = "";

        // Number of copies available in the library
        [Display(Name = "Copies Available")]
        [Required(ErrorMessage = "'{0}' field is required.")] // "'{0}' alanı gereklidir."
        [Range(1, int.MaxValue, ErrorMessage = "'{0}' field can't be less than 1")] // "'{0}' alanı 1'den küçük olamaz."
        public int CopiesAvailable { get; set; } = 0;
    }
}
