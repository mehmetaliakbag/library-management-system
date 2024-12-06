namespace LibraryManagementSystem.Models
{
    // Represents an author in the library system
    public class Author
    {
        // Unique identifier for the author
        public int Id { get; set; }

        // First name of the author
        public string FirstName { get; set; }

        // Last name of the author
        public string LastName { get; set; }

        // Date of birth of the author
        public DateTime DateOfBirth { get; set; }
    }
}
