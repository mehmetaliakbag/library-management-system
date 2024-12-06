using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Data
{
    // LibraryDataService class is used to provide mock data for authors and books
    public class LibraryDataService
    {
        // Static list of authors in the library
        public static List<Author> authors = new()
        {
            new Author
            {
                Id = 1,
                FirstName = "William",
                LastName = "Shakespeare",
                DateOfBirth = new DateTime(1564, 4, 23)
            },
            new Author
            {
                Id = 2,
                FirstName = "Leo",
                LastName = "Tolstoy",
                DateOfBirth = new DateTime(1828, 9, 9)
            },
            new Author
            {
                Id = 3,
                FirstName = "Alexandre",
                LastName = "Dumas",
                DateOfBirth = new DateTime(1802, 7, 24)
            },
            new Author
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Austen",
                DateOfBirth = new DateTime(1775, 12, 16)
            },
            new Author
            {
                Id = 5,
                FirstName = "Charles",
                LastName = "Dickens",
                DateOfBirth = new DateTime(1812, 2, 7)
            },
            new Author
            {
                Id = 6,
                FirstName = "Mark",
                LastName = "Twain",
                DateOfBirth = new DateTime(1835, 11, 30)
            },
            new Author
            {
                Id = 7,
                FirstName = "Herman",
                LastName = "Melville",
                DateOfBirth = new DateTime(1819, 8, 1)
            },
            new Author
            {
                Id = 8,
                FirstName = "F. Scott",
                LastName = "Fitzgerald",
                DateOfBirth = new DateTime(1896, 9, 24)
            },
            new Author
            {
                Id = 9,
                FirstName = "George",
                LastName = "Orwell",
                DateOfBirth = new DateTime(1903, 6, 25)
            },
            new Author
            {
                Id = 10,
                FirstName = "J.K.",
                LastName = "Rowling",
                DateOfBirth = new DateTime(1965, 7, 31)
            }
        };

        // Static list of books in the library
        public static List<Book> books = new()
{
    // Shakespeare's Books
    new Book
    {
        Id = 1,
        Title = "Hamlet",
        AuthorId = 1, // Shakespeare'in ID'si
        Genre = "Tragedy",
        PublishDate = new DateTime(1600, 1, 1),
        ISBN = "978-0-141-01070-0", // Correct ISBN Format
        CopiesAvailable = 35
    },
    new Book
    {
        Id = 2,
        Title = "Macbeth",
        AuthorId = 1, // Shakespeare'in ID'si
        Genre = "Tragedy",
        PublishDate = new DateTime(1606, 1, 1),
        ISBN = "978-0-141-01141-1", // Correct ISBN Format
        CopiesAvailable = 71
    },
    new Book
    {
        Id = 3,
        Title = "Romeo and Juliet",
        AuthorId = 1, // Shakespeare'in ID'si
        Genre = "Tragedy",
        PublishDate = new DateTime(1597, 1, 1),
        ISBN = "978-0-743-47711-6", // Correct ISBN Format
        CopiesAvailable = 6
    },
    new Book
    {
        Id = 4,
        Title = "Othello",
        AuthorId = 1, // Shakespeare'in ID'si
        Genre = "Tragedy",
        PublishDate = new DateTime(1604, 1, 1),
        ISBN = "978-0-451-52832-5", // Correct ISBN Format
        CopiesAvailable = 34
    },

    // Tolstoy's Books
    new Book
    {
        Id = 6,
        Title = "War and Peace",
        AuthorId = 2, // Tolstoy'un ID'si
        Genre = "Historical Fiction",
        PublishDate = new DateTime(1869, 1, 1),
        ISBN = "978-0-199-23276-5", // Correct ISBN Format
        CopiesAvailable = 96
    },
    new Book
    {
        Id = 7,
        Title = "Anna Karenina",
        AuthorId = 2, // Tolstoy'un ID'si
        Genre = "Novel",
        PublishDate = new DateTime(1877, 1, 1),
        ISBN = "978-0-143-03500-8", // Correct ISBN Format
        CopiesAvailable = 101
    },
    new Book
    {
        Id = 8,
        Title = "The Death of Ivan Ilyich",
        AuthorId = 2, // Tolstoy'un ID'si
        Genre = "Novella",
        PublishDate = new DateTime(1886, 1, 1),
        ISBN = "978-1-503-27783-3", // Correct ISBN Format
        CopiesAvailable = 3
    },

    // Dumas's Books
    new Book
    {
        Id = 9,
        Title = "The Three Musketeers",
        AuthorId = 3, // Dumas'ın ID'si
        Genre = "Historical Adventure",
        PublishDate = new DateTime(1844, 1, 1),
        ISBN = "978-1-503-28103-3", // Correct ISBN Format
        CopiesAvailable = 11
    },
    new Book
    {
        Id = 10,
        Title = "The Count of Monte Cristo",
        AuthorId = 3, // Dumas'ın ID'si
        Genre = "Adventure",
        PublishDate = new DateTime(1844, 1, 1),
        ISBN = "978-0-140-44926-6", // Correct ISBN Format
        CopiesAvailable = 314
    },

    // Jane Austen's Books
    new Book
    {
        Id = 11,
        Title = "Pride and Prejudice",
        AuthorId = 4, // Austen'in ID'si
        Genre = "Romance",
        PublishDate = new DateTime(1813, 1, 1),
        ISBN = "978-0-141-04034-9", // Correct ISBN Format
        CopiesAvailable = 50
    },
    new Book
    {
        Id = 12,
        Title = "Sense and Sensibility",
        AuthorId = 4, // Austen'in ID'si
        Genre = "Romance",
        PublishDate = new DateTime(1811, 1, 1),
        ISBN = "978-0-141-19878-7", // Correct ISBN Format
        CopiesAvailable = 32
    },
    new Book
    {
        Id = 13,
        Title = "Emma",
        AuthorId = 4, // Austen'in ID'si
        Genre = "Romance",
        PublishDate = new DateTime(1815, 1, 1),
        ISBN = "978-0-141-43958-7", // Correct ISBN Format
        CopiesAvailable = 40
    },

    // Charles Dickens's Books
    new Book
    {
        Id = 14,
        Title = "Great Expectations",
        AuthorId = 5, // Dickens'in ID'si
        Genre = "Novel",
        PublishDate = new DateTime(1861, 1, 1),
        ISBN = "978-1-853-26104-7", // Correct ISBN Format
        CopiesAvailable = 80
    },
    new Book
    {
        Id = 15,
        Title = "A Tale of Two Cities",
        AuthorId = 5, // Dickens'in ID'si
        Genre = "Historical Fiction",
        PublishDate = new DateTime(1859, 1, 1),
        ISBN = "978-1-853-26039-2", // Correct ISBN Format
        CopiesAvailable = 72
    },

    // Mark Twain's Books
    new Book
    {
        Id = 16,
        Title = "The Adventures of Tom Sawyer",
        AuthorId = 6, // Twain'in ID'si
        Genre = "Adventure",
        PublishDate = new DateTime(1876, 1, 1),
        ISBN = "978-0-486-40077-8", // Correct ISBN Format
        CopiesAvailable = 120
    },
    new Book
    {
        Id = 17,
        Title = "Adventures of Huckleberry Finn",
        AuthorId = 6, // Twain'in ID'si
        Genre = "Adventure",
        PublishDate = new DateTime(1884, 1, 1),
        ISBN = "978-0-486-28061-5", // Correct ISBN Format
        CopiesAvailable = 55
    },

    // Herman Melville's Books
    new Book
    {
        Id = 18,
        Title = "Moby-Dick",
        AuthorId = 7, // Melville'in ID'si
        Genre = "Adventure",
        PublishDate = new DateTime(1851, 1, 1),
        ISBN = "978-1-503-28078-4", // Correct ISBN Format
        CopiesAvailable = 63
    },
    new Book
    {
        Id = 19,
        Title = "Billy Budd",
        AuthorId = 7, // Melville'in ID'si
        Genre = "Novella",
        PublishDate = new DateTime(1891, 1, 1),
        ISBN = "978-1-503-28065-4", // Correct ISBN Format
        CopiesAvailable = 25
    },

    // F. Scott Fitzgerald's Books
    new Book
    {
        Id = 20,
        Title = "The Great Gatsby",
        AuthorId = 8, // Fitzgerald'in ID'si
        Genre = "Novel",
        PublishDate = new DateTime(1925, 1, 1),
        ISBN = "978-0-743-27356-5", // Correct ISBN Format
        CopiesAvailable = 130
    },

    // George Orwell's Books
    new Book
    {
        Id = 21,
        Title = "1984",
        AuthorId = 9, // Orwell'in ID'si
        Genre = "Dystopian",
        PublishDate = new DateTime(1949, 1, 1),
        ISBN = "978-0-451-52493-5", // Correct ISBN Format
        CopiesAvailable = 98
    },

    // J.K. Rowling's Books
    new Book
    {
        Id = 22,
        Title = "Harry Potter and the Sorcerer's Stone",
        AuthorId = 10, // Rowling'in ID'si
        Genre = "Fantasy",
        PublishDate = new DateTime(1997, 6, 26),
        ISBN = "978-0-590-35342-7", // Correct ISBN Format
        CopiesAvailable = 220
    }
};
    }
}
