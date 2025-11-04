# amazoon Project Documentation

## Project Overview

This project, named "amazoon," is a basic e-commerce application built with ASP.NET Core MVC and Entity Framework Core. It currently features a foundational structure with models for products, orders, users, and categories, along with basic CRUD (Create, Read, Update, Delete) functionality for managing product categories.

## Setup Instructions

Follow these steps to set up and run the project.

### Prerequisites

*   .NET SDK 8.0 or later
*   SQL Server LocalDB (usually installed with Visual Studio)
*   Entity Framework Core CLI Tools (already installed globally if you followed previous steps):
    ```bash
    dotnet tool install --global dotnet-ef
    ```

### 1. Database Configuration

The application uses a local SQL Server database. The connection string is configured in `appsettings.json`.

**`appsettings.json`:**

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "defaultconnection": "Server=(localdb)\\MSSQLLocalDB;Database=amazoon_db;Trusted_Connection=True"
  }
}
```

The database name is `amazoon_db`. If this database does not exist, it will be created automatically when applying migrations.

### 2. Apply Database Migrations

Navigate to the project root directory (`D:\ShopVerse\amazon\`) in your terminal and run the following commands to create and apply the database schema:

```bash
dotnet ef migrations add InitialCreate --project amazoon.csproj
dotnet ef database update --project amazoon.csproj
```

These commands will:
*   Create an `InitialCreate` migration based on the models in the `Models` folder.
*   Update your SQL Server LocalDB instance to create the `amazoon_db` database and all defined tables (Categories, Products, Users, Orders, OrderItems, Reviews, Payments).

### 3. Build the Project

Before running, build the project to ensure all dependencies are restored and compiled:

```bash
dotnet build amazoon.sln
```

## Features

### Category Management (CRUD)

The application includes full CRUD functionality for product categories:

*   **View Categories:** List all existing product categories.
*   **Create Category:** Add a new product category.
*   **Edit Category:** Modify the details of an existing category.
*   **Delete Category:** Remove a category.

To access category management, run the application and click on the "Categories" link in the navigation bar.

## Running the Application

To run the application, execute the following command from the project root directory (`D:\ShopVerse\amazon\`):

```bash
dotnet run --project amazoon.csproj
```

The application will typically launch on `https://localhost:7021` (or a similar port). You can then open this URL in your web browser.

## Project Structure

*   **`amazoon.csproj`**: Project file defining dependencies and target framework.
*   **`Program.cs`**: Application entry point, configures services (including `AppDbContext`) and the HTTP request pipeline.
*   **`appsettings.json`**: Configuration file, including the database connection string.
*   **`Models/`**: Contains the C# model classes that map to database tables (e.g., `Category.cs`, `Order.cs`, `Product.cs`, `User.cs`, etc.). It also includes `AppDbContext.cs` for database context configuration.
*   **`Controllers/`**: Contains MVC controllers. `CategoryController.cs` handles category CRUD operations.
*   **`Views/`**: Contains Razor views for the user interface, organized by controller (e.g., `Views/Category/Index.cshtml`, `Views/Shared/_Layout.cshtml`).
*   **`wwwroot/`**: Static files like CSS, JavaScript, and images.

Enjoy using the amazoon application!
