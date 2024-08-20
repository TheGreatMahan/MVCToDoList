# To-Do List Application

This is a To-Do List application built using MVC .NET, leveraging Razor views for dynamic front-end rendering and Microsoft SQL Server for data management. The application allows users to add, delete, and mark tasks as complete.

## Features

- **Create Tasks:** Add new tasks to the to-do list with a title and description.
- **Delete Tasks:** Remove tasks from the list.
- **Mark Tasks as Complete:** Check off tasks that have been completed.
- **View Tasks:** Display all tasks in an organized list.

## Prerequisites

Before you begin, ensure you have met the following requirements:
- .NET 8.0 SDK
- Microsoft SQL Server
- Visual Studio 2022 or later

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/TheGreatMahan/MVCToDoList.git
   cd MVCToDoList
   ```

2. **Set up the database:**
   - Open SQL Server Management Studio (SSMS).
   - Execute the SQL script located in `Database/InitDB.sql` to set up your database and tables.

3. **Configure the connection string:**
   - Open the `appsettings.json` file.
   - Modify the `DefaultConnection` string with your SQL Server instance details.

4. **Build the application:**
   ```bash
   dotnet build
   ```

5. **Run the application:**
   ```bash
   dotnet run
   ```

## Usage

Once the application is running, navigate to `https://localhost:7218/` in your web browser to start using the To-Do List application. You can add new tasks, delete old ones, and toggle their completion status directly from the interface.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

![image](https://github.com/user-attachments/assets/a49d53c0-1424-477c-a2bf-86c22a5cd81e)
![image](https://github.com/user-attachments/assets/26bdb57c-176a-4a2e-9d3c-a0467fb9a6ee)
![image](https://github.com/user-attachments/assets/3018ae75-3130-4732-87d4-d9654bc69337)
![image](https://github.com/user-attachments/assets/dddd0738-319e-44ec-87ec-a17d06d5b009)
