using LibraryManagementSystem.ViewModels.Book;

namespace LibraryManagementSystem.ViewModels.Author
{
    // Represents the view model for displaying detailed information about an author
    public class AuthorDetailsViewModel
    {
        // First name of the author
        public string FirstName { get; set; } = "";

        // Last name of the author
        public string LastName { get; set; } = "";

        // Date of birth of the author
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;

        // List of books written by the author
        public List<BookListViewModel> Books { get; set; } = new();
    }
}

