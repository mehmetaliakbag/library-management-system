namespace LibraryManagementSystem.Models
{
    // Represents a book entity in the library system
    public class Book
    {
        // Unique identifier for the book
        public int Id { get; set; }

        // Title of the book
        public string Title { get; set; }

        // Identifier for the author of the book (foreign key)
        public int AuthorId { get; set; }

        // Genre or category of the book
        public string Genre { get; set; }

        // Publication date of the book
        public DateTime PublishDate { get; set; }

        // International Standard Book Number
        public string ISBN { get; set; }

        // Number of copies currently available in the library
        public int CopiesAvailable { get; set; }
    }
}
