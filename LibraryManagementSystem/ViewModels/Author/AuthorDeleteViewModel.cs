namespace LibraryManagementSystem.ViewModels.Author
{
    // Represents the view model for deleting an author
    public class AuthorDeleteViewModel
    {
        // Unique identifier of the author
        public int Id { get; set; }

        // Full name of the author (FirstName + LastName)
        public string FullName { get; set; } = "";
    }
}
