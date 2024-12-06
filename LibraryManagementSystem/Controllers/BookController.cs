using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem.Controllers
{
    // Controller for managing books in the Library Management System
    public class BookController : Controller
    {
        // Action to display a list of books
        public IActionResult List()
        {
            // Create a list of books with their serial numbers and titles
            List<BookListViewModel> listOfBooks = LibraryDataService.books
                .OrderBy(book => book.Title)
                .Select((book, index) => new BookListViewModel
                {
                    Id = book.Id,
                    SerialNumber = index + 1, // Serial number of the book in the list
                    Title = book.Title
                })
                .ToList();

            // Return the view with the list of books
            return View(listOfBooks);
        }

        // Action to show details of a specific book
        public IActionResult Details(int id)
        {
            // Find the selected book by ID
            Book? selectedBook = LibraryDataService.books
                .FirstOrDefault(book => book.Id == id);

            // If the book is not found, return a 404 error
            if (selectedBook == null)
                return NotFound();

            // Find the author of the selected book
            Author? authorOfSelectedBook = LibraryDataService.authors
                .FirstOrDefault(author => author.Id == selectedBook.AuthorId);

            // If the author is not found, return a 404 error
            if (authorOfSelectedBook == null)
                return NotFound();

            // Combine the author's first and last names
            string authorFullName = $"{authorOfSelectedBook.FirstName} {authorOfSelectedBook.LastName}";

            // Create a ViewModel to pass the book's details to the view
            BookDetailsViewModel detailsOfBook = new()
            {
                Title = selectedBook.Title,
                Author = authorFullName,
                Genre = selectedBook.Genre,
                PublishDate = selectedBook.PublishDate,
                ISBN = selectedBook.ISBN,
                CopiesAvailable = selectedBook.CopiesAvailable
            };

            // Return the view with the book's details
            return View(detailsOfBook);
        }

        // Action to show the form for creating a new book
        public IActionResult Create()
        {
            // Initialize a new BookCreateViewModel
            BookCreateViewModel bookCreationModel = new();

            // Populate the Authors dropdown for the book creation form
            ViewBag.Authors = LibraryDataService.authors
                .Select(author => new SelectListItem
                {
                    Value = author.Id.ToString(),
                    Text = $"{author.FirstName} {author.LastName}"
                })
                .ToList();

            // Return the view with the empty model
            return View(bookCreationModel);
        }

        // POST method to handle form submission for creating a new book
        [HttpPost]
        public IActionResult Create(BookCreateViewModel bookCreationModel)
        {
            // If the form submission is valid, create a new book
            if (ModelState.IsValid)
            {
                Book newBook = new()
                {
                    Id = LibraryDataService.books.Max(book => book.Id) + 1, // Increment the Id for the new book
                    Title = bookCreationModel.Title,
                    AuthorId = bookCreationModel.AuthorId,
                    Genre = bookCreationModel.Genre,
                    PublishDate = bookCreationModel.PublishDate,
                    ISBN = bookCreationModel.ISBN,
                    CopiesAvailable = bookCreationModel.CopiesAvailable
                };

                // Add the new book to the list of books
                LibraryDataService.books.Add(newBook);

                TempData["Message"] = "The book added successfully.";

                // Redirect to the list of books after creation
                return RedirectToAction("List");
            }

            // If the form submission is invalid, re-render the form with validation errors
            ViewBag.Authors = LibraryDataService.authors
                .Select(author => new SelectListItem
                {
                    Value = author.Id.ToString(),
                    Text = $"{author.FirstName} {author.LastName}"
                })
                .ToList();

            // Return the view with the invalid model to correct errors
            return View(bookCreationModel);
        }

        // Action to show the form for editing an existing book
        public IActionResult Edit(int id)
        {
            // Find the book by ID to be edited
            Book? selectedBook = LibraryDataService.books.FirstOrDefault(book => book.Id == id);

            // If the book is not found, return a 404 error
            if (selectedBook == null)
                return NotFound();

            // Initialize the BookEditViewModel with the selected book's data
            BookEditViewModel bookEditingModel = new()
            {
                Id = selectedBook.Id,
                Title = selectedBook.Title,
                AuthorId = selectedBook.AuthorId,
                Genre = selectedBook.Genre,
                PublishDate = selectedBook.PublishDate,
                ISBN = selectedBook.ISBN,
                CopiesAvailable = selectedBook.CopiesAvailable
            };

            // Populate the Authors dropdown for the book editing form
            ViewBag.Authors = LibraryDataService.authors
                .Select(author => new SelectListItem
                {
                    Value = author.Id.ToString(),
                    Text = $"{author.FirstName} {author.LastName}"
                })
                .ToList();

            // Return the view with the editing model
            return View(bookEditingModel);
        }

        // POST method to handle form submission for editing an existing book
        [HttpPost]
        public IActionResult Edit(BookEditViewModel bookEditingModel)
        {
            // Find the book by ID to be edited
            Book? editedBook = LibraryDataService.books.FirstOrDefault(book => book.Id == bookEditingModel.Id);

            // If the book is not found, return a 404 error
            if (editedBook == null)
                return NotFound();

            // If the form submission is valid, update the book's data
            if (ModelState.IsValid)
            {
                editedBook.Title = bookEditingModel.Title;
                editedBook.AuthorId = bookEditingModel.AuthorId;
                editedBook.Genre = bookEditingModel.Genre;
                editedBook.PublishDate = bookEditingModel.PublishDate;
                editedBook.ISBN = bookEditingModel.ISBN;
                editedBook.CopiesAvailable = bookEditingModel.CopiesAvailable;

                TempData["Message"] = "The book was edited successfully.";

                // Redirect to the list of books after editing
                return RedirectToAction("List");
            }

            // If the form submission is invalid, re-render the form with validation errors
            ViewBag.Authors = LibraryDataService.authors
                .Select(author => new SelectListItem
                {
                    Value = author.Id.ToString(),
                    Text = $"{author.FirstName} {author.LastName}"
                })
                .ToList();

            // Return the view with the invalid model to correct errors
            return View(bookEditingModel);
        }

        // Action to show the form for deleting a book
        public IActionResult Delete(int id)
        {
            // Find the book by ID to be deleted
            Book? selectedBook = LibraryDataService.books.FirstOrDefault(book => book.Id == id);

            // If the book is not found, return a 404 error
            if (selectedBook == null)
                return NotFound();

            // Initialize the BookDeleteViewModel with the book's data
            BookDeleteViewModel bookDeleteModel = new()
            {
                Id = selectedBook.Id,
                Title = selectedBook.Title
            };

            // Return the view with the book delete model
            return View(bookDeleteModel);
        }

        // POST method to confirm the deletion of a book
        [HttpPost]
        public IActionResult DeleteConfirmed(BookDeleteViewModel bookDeleteModel)
        {
            // Find the book by ID to be deleted
            Book? selectedBook = LibraryDataService.books.FirstOrDefault(book => book.Id == bookDeleteModel.Id);

            // If the book is not found, return a 404 error
            if (selectedBook == null)
                return NotFound();

            // Remove the book from the list of books
            LibraryDataService.books.Remove(selectedBook);

            TempData["Message"] = "The book was deleted successfully.";

            // Redirect to the list of books after deletion
            return RedirectToAction("List");
        }
    }
}

