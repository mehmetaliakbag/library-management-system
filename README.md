# Library Management System

## Project Overview
The Library Management System is a web application that allows libraries to manage books, authors, and user information. 
With this application, users can add, edit, delete, and view books and authors.

## Technologies Used
- **ASP.NET Core MVC**: Framework used for building the core structure of the application.
- **Bootstrap**: Used for designing the user interface.
- **jQuery**: Utilized for dynamic page operations.

## Data Management
This project uses the following structures for data storage instead of a database:
- **List<Book>**: Used to manage books.
- **List<Author>**: Used to manage authors.

Data management is handled by the **LibraryServiceData** class, which is responsible for managing the book and author lists.

## Setup and Run Instructions
1. **Download and Open Project Files**: Open the `LibraryManagementSystem.sln` file in Visual Studio.
2. **Install Required Dependencies**: In Visual Studio, go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution` to install missing packages.
3. **Run the Project**: Use either **IIS Express** or **Kestrel** to run the application in Visual Studio.

## Documentation

### Project Configuration
- **Data Storage**: `LibraryServiceData` class contains `List<Book>` and `List<Author>` for data storage.
- **Layered Architecture**: The project follows the MVC (Model-View-Controller) architecture.
- **Static Files**: All CSS and JavaScript files are stored in the `wwwroot` directory.

### Workflow
1. The user visits the homepage and accesses the book list.
2. The user can add a new book or author.
3. Existing records can be edited or deleted.
4. Each operation is handled via a combination of controllers and views.

### Testing Processes
- **Manual Testing**: The project has been tested in the browser by simulating user scenarios.
- **Unit Testing**: Unit tests have been written for controller and model classes. To run test scenarios:
  
  ```bash
  dotnet test
  ```
  
### Project Structure
Controllers: Classes controlling the business logic (AuthorController.cs, BookController.cs, HomeController.cs).
Models: Data models for the application (Author.cs, Book.cs, ErrorViewModel.cs).
Views: Razor pages designed for the user interface.
wwwroot: Static files (CSS, JavaScript, images).

###### License
This version is ready for an international audience. Let me know if you need further refinements! 🌍
