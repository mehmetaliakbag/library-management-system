using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.ViewModels.Author;
using LibraryManagementSystem.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult List()
        {
            List<AuthorListViewModel> listOfAuthors = LibraryDataService.authors
                .OrderBy(author => author.FirstName)
                .Select((author, index) => new AuthorListViewModel
                {
                    Id = author.Id,
                    SerialNumber = index + 1,
                    FullName = $"{author.FirstName} {author.LastName}"
                })
                .ToList();

            return View(listOfAuthors);
        }

        public IActionResult Details(int id)
        {
            Author? selectedAuthor = LibraryDataService.authors
                .FirstOrDefault(author => author.Id == id);

            if (selectedAuthor == null)
                return View();

            List<BookListViewModel> listOfBooks = LibraryDataService.books
                .Where(book => book.AuthorId == id)
                .Select(book => new BookListViewModel
                {
                    Id = 0,
                    SerialNumber = 0,
                    Title = book.Title
                }).ToList();

            AuthorDetailsViewModel detailsOfAuthor = new()
            {
                FirstName = selectedAuthor.FirstName,
                LastName = selectedAuthor.LastName,
                DateOfBirth = selectedAuthor.DateOfBirth,
                Books = listOfBooks
            };

            return View(detailsOfAuthor);
        }

        public IActionResult Create()
        {
            AuthorCreateViewModel authorCreationModel = new();

            return View(authorCreationModel);
        }

        [HttpPost]
        public IActionResult Create(AuthorCreateViewModel authorCreationModel)
        {
            if (ModelState.IsValid)
            {
                Author newAuthor = new()
                {
                    Id = LibraryDataService.authors.Max(author => author.Id) + 1,
                    FirstName = authorCreationModel.FirstName,
                    LastName = authorCreationModel.LastName,
                    DateOfBirth = authorCreationModel.DateOfBirth,
                };

                LibraryDataService.authors.Add(newAuthor);

                TempData["Message"] = "The book was added successfully.";

                return RedirectToAction("List");
            }

            return View(authorCreationModel);
        }

        public IActionResult Edit(int id)
        {
            Author? selectedAuthor = LibraryDataService.authors.FirstOrDefault(book => book.Id == id);

            if (selectedAuthor == null)
                return NotFound();

            AuthorEditViewModel authorEditingModel = new()
            {
                Id = selectedAuthor.Id,
                FirstName = selectedAuthor.FirstName,
                LastName = selectedAuthor.LastName,
                DateOfBirth = selectedAuthor.DateOfBirth
            };

            return View(authorEditingModel);
        }

        [HttpPost]
        public IActionResult Edit(AuthorEditViewModel authorEditingModel)
        {
            Author? editedAuthor = LibraryDataService.authors.FirstOrDefault(author => author.Id == authorEditingModel.Id);

            if (editedAuthor == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                editedAuthor.FirstName = authorEditingModel.FirstName;
                editedAuthor.LastName = authorEditingModel.LastName;
                editedAuthor.DateOfBirth = authorEditingModel.DateOfBirth;

                TempData["Message"] = "The book was edited successfully.";

                return RedirectToAction("List");
            }

            return View(editedAuthor);
        }

        public IActionResult Delete(int id)
        {
            Author? selectedAuthor = LibraryDataService.authors.FirstOrDefault(author => author.Id == id);

            if (selectedAuthor == null)
                return NotFound();

            AuthorDeleteViewModel authorDeleteModel = new()
            {
                Id = selectedAuthor.Id,
                FullName = $"{selectedAuthor.FirstName} {selectedAuthor.LastName}",
            };

            return View(authorDeleteModel);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(AuthorDeleteViewModel authorDeleteModel)
        {
            Author? selectedAuthor = LibraryDataService.authors.FirstOrDefault(author => author.Id == authorDeleteModel.Id);

            if (selectedAuthor == null)
                return NotFound();

            LibraryDataService.authors.Remove(selectedAuthor);

            TempData["Message"] = "The book was deleted successfully.";

            return RedirectToAction("List");
        }

    }
}
