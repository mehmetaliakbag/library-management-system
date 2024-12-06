namespace LibraryManagementSystem.ViewModels.Book
{
    // Represents the view model for displaying detailed information about a book
    public class BookDetailsViewModel
    {
        // Title of the book
        public string Title { get; set; } = "";

        // Author of the book
        public string Author { get; set; } = "";

        // Genre or category of the book
        public string Genre { get; set; } = "";

        // Publication date of the book
        public DateTime PublishDate { get; set; } = DateTime.MinValue;

        // International Standard Book Number
        public string ISBN { get; set; } = "";

        // Number of copies currently available in the library
        public int CopiesAvailable { get; set; } = 0;
    }
}
