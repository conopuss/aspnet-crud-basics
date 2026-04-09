# ASP.NET Core CRUD Practice Project

## Overview

This project is a full-stack ASP.NET Core application built to reinforce core backend development concepts through daily repetition. The application combines both MVC and REST API approaches within the same solution.

## Purpose

The primary goal of this project is to strengthen understanding of backend architecture by rebuilding the application from scratch on a regular basis. This approach ensures deeper familiarity with core concepts rather than relying on copy-paste implementations.

## Architecture

The project follows a layered architecture:

* Controller Layer (MVC & API)
* Service Layer (Business Logic)
* Repository Layer (Data Access)
* Data Layer (Entity Framework Core)

This structure promotes separation of concerns, maintainability, and testability.

## Technologies

* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* SQLite (self-contained database)
* LINQ
* xUnit (Unit Testing)

## Key Features

### 1. Full CRUD Operations

* Implemented both via MVC and REST API
* Supports Create, Read, Update, and Delete operations

### 2. DTO & ViewModel Separation

* DTOs are used for API communication
* ViewModels are used for UI interactions
* Prevents direct exposure of domain entities

### 3. Database

* SQLite is used to ensure zero external dependency
* The project includes a pre-populated database (`app.db`)
* The application runs immediately after cloning

### 4. Validation

* Implemented using Data Annotations
* Ensures data integrity on both UI and API layers

### 5. LINQ Usage

* Used for querying and transforming data
* Demonstrates filtering, ordering, and projection

### 6. Exception Handling

* Custom middleware for global exception handling
* Returns structured error responses

### 7. Dependency Injection

* Built-in ASP.NET Core DI is used throughout the project

### 8. Unit Testing

* Separate test project using xUnit
* Includes service-level tests with a fake repository

### 9. Hybrid MVC + API Interaction

* Traditional MVC form submissions are used alongside API calls
* AJAX (Fetch API) is used for asynchronous CRUD operations
* Demonstrates understanding of client-server interaction without full frontend frameworks

## How to Run

1. Clone the repository
2. Navigate to the project directory (the folder containing the `.csproj` file):

```bash
cd aspnet-crud-basics/ASP_CRUD_and_git_practice

3. Run:

```bash
dotnet run
```

4. After the application starts, check the console output for the URL:

Example: Now listening on: http://localhost:5044


5. Open the displayed URL in your browser.

The application will run with a ready-to-use SQLite database.

## Notes

* This project is intentionally kept simple in terms of UI to focus on backend architecture and logic.
* The application is rebuilt regularly as part of a structured learning routine.

## Author
Irmak Sabuncu
