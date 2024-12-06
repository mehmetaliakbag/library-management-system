namespace LibraryManagementSystem.ViewModels.Book
{
    // Represents the view model for displaying a list of books
    public class BookListViewModel
    {
        // Unique identifier for the book
        public int Id { get; set; }

        // Serial number used for listing or ordering books
        public int SerialNumber { get; set; }

        // Title of the book
        public string Title { get; set; } = "";
    }
}
