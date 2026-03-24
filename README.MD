# TrekTopia

## Description
TrekTopia is a desktop-based trip planning application built to make travel planning easier and more convenient. It provides a user-friendly interface where users can sign up, log in, and explore travel options in one place. The project integrates real-time flight and hotel related features to help travelers find suitable options based on their destination and travel needs.

The application simplifies the process of planning trips by combining multiple travel services into a single platform. It also includes a local database system for storing user account information and uses external API integration to fetch travel data. TrekTopia is designed to give users a smooth and organized experience whether they are planning a vacation in advance or looking for quick travel options.

## Team Members
- Rafay Rizwan (24L-2614)
- Hamza Bakir (24L-2505)
- Dawood Majeed (24L-2538)

## Tech Stack
- Language: C#
- Framework: .NET 8 Windows Forms
- Frontend: Windows Forms UI
- Backend: C# application logic
- Database: SQLite
- ORM/Database Package: Microsoft.EntityFrameworkCore.Sqlite
- API Integration: Amadeus API
- JSON Handling: Newtonsoft.Json

## Project Structure
- `frontend/` contains the user interface forms such as login, signup, flights, hotels, cars, and maps
- `backend/` contains business logic and API-related files such as `AmadeusAPI.cs` and `FlightObject.cs`
- `database/` contains the SQLite database file and database handling code
- `assets/` contains images and resource files
- `project_files/` contains the solution file, project file, and startup file

## How to Run

### Prerequisites
Make sure you have the following installed:
- Visual Studio 2022 or later with .NET desktop development workload
- .NET 8 SDK

### Steps
1. Extract the project files.
2. Open the solution file `WinFormsApp1.sln` in Visual Studio.
3. Restore the required NuGet packages.
4. Build the project.
5. Run the application.

### Using .NET CLI
You can also run the project using the terminal:

```bash
cd project_files
dotnet restore
dotnet build
dotnet run --project WinFormsApp1.csproj
