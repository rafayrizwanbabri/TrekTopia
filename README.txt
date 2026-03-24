Sorted project structure

frontend: WinForms UI forms, designer files, and UI code-behind
backend: business logic and API/model classes
database: SQLite database file and database access class
assets: images and .resx resource files
project_files: solution, project, startup, and properties files
generated_files: bin and obj build output
version_control: .git content and git config files
other: anything not matching above

Notes:
- This is a Windows Forms desktop app, so there is no separate web frontend/backend split like a website.
- Most form .cs files contain both UI event handlers and some app logic, so they were placed under frontend because they directly drive the interface.
- Database.cs and Data.db were placed under database.
- AmadeusAPI.cs and FlightObject.cs were placed under backend.
