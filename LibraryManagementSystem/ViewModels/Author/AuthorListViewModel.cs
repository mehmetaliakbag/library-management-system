namespace LibraryManagementSystem.ViewModels.Author
{
    // Represents the view model for displaying a list of authors
    public class AuthorListViewModel
    {
        // Unique identifier for the author
        public int Id { get; set; }

        // Serial number of the author in the list
        public int SerialNumber { get; set; }

        // Full name of the author (first and last name concatenated)
        public string FullName { get; set; } = "";
    }
}
