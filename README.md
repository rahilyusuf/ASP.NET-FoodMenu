Food Menu Web App

Description

The Food Menu Web App is a web-based application built using ASP.NET Core and Entity Framework. This application allows users to browse a restaurant's menu, view dish details, and manage menu items dynamically.

Features

🍽️ Browse Menu - View a list of available dishes with images and descriptions.

✏️ Manage Dishes - Add, edit, and delete dishes.

📷 Image Integration - Display dish images using URL storage.

🗄️ Database Integration - Uses Entity Framework Core with SQL Server.

📱 Responsive Design - Works on both mobile and desktop.

🔐 Authentication & Authorization (Optional) - Secure user access with ASP.NET Identity.

Tech Stack

Backend: ASP.NET Core, Entity Framework Core

Frontend: Razor Pages / Blazor / React (optional)

Database: SQL Server (EF Core)

Authentication: Identity (if needed)

Setup Instructions

1️⃣ Clone the Repository

git clone https://github.com/yourusername/FoodMenuWebApp.git
cd FoodMenuWebApp

2️⃣ Configure the Database

Open appsettings.json and update the connection string:

"ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=FoodMenuDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

Run database migrations:

dotnet ef migrations add InitialCreate
dotnet ef database update

3️⃣ Run the Application

dotnet run

The app will be available at: http://localhost:5000

Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

License

This project is licensed under the MIT License. See the LICENSE file for details.

