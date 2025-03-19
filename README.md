# 🎓 StudentAPI - ASP.NET Core Web API

  

Welcome to StudentAPI, a simple yet powerful RESTful API built with ASP.NET Core. This project demonstrates CRUD operations (Create, Read, Update, Delete) for managing student records and serves as an excellent learning resource for beginners in web API development.

🚀 Features

✔️ Fully functional REST API for student management
✔️ CRUD operations (Create, Read, Update, Delete)
✔️ In-memory data storage (easily extendable to SQL database)
✔️ CORS enabled to allow cross-origin requests
✔️ Swagger UI for easy API testing
✔️ Structured API routes following best practices
✔️ Lightweight & scalable for deployment

🛠 Tech Stack

🔹 Backend: C# (.NET 7/8), ASP.NET Core Web API🔹 Tools: Visual Studio, Postman, Swagger UI🔹 Version Control: Git & GitHub🔹 Testing: Postman, cURL🔹 Deployment: Azure / AWS (Future Enhancements)

📂 Project Structure

StudentAPI/
├── Controllers/
│   ├── StudentsController.cs  # API Endpoints
├── Models/
│   ├── Student.cs  # Data Model
├── Properties/
│   ├── launchSettings.json  # Launch Configurations
├── appsettings.json  # Configuration File
├── Program.cs  # Main Application Entry
├── StudentAPI.csproj  # Project Configuration
├── .gitignore  # Files to ignore in Git
└── README.md  # Project Documentation

🎯 Getting Started

Follow these simple steps to set up and run the StudentAPI on your local machine.

✅ 1. Clone the Repository

git clone https://github.com/yourusername/StudentAPI.git
cd StudentAPI

✅ 2. Install Required Tools

🔹 .NET SDK - Download Here🔹 Visual Studio Code (Optional) - Download Here🔹 Postman (For API Testing) - Download Here

✅ 3. Run the API

dotnet run

Your API will start at:

http://localhost:5000

✅ 4. Access Swagger UI

Once the API is running, open Swagger UI to interact with the API:
👉 http://localhost:5000/swagger

📌 API Endpoints

Method

Endpoint

Description

GET

/api/students

Get all students

GET

/api/students/{id}

Get student by ID

POST

/api/students

Create a new student

PUT

/api/students/{id}

Update an existing student

DELETE

/api/students/{id}

Delete a student

🧪 API Testing (Postman / cURL)

🔹 Get All Students (GET)

curl -X GET http://localhost:5000/api/students

🔹 Add a Student (POST)

curl -X POST http://localhost:5000/api/students -H "Content-Type: application/json" -d '{"name": "Charlie", "course": "Cybersecurity"}'

🔹 Update a Student (PUT)

curl -X PUT http://localhost:5000/api/students/1 -H "Content-Type: application/json" -d '{"name": "Alice Updated", "course": "AI"}'

🔹 Delete a Student (DELETE)

curl -X DELETE http://localhost:5000/api/students/1

📜 How to Deploy (Optional)

Want to host the API online? Follow these steps:
1️⃣ Azure Deployment - Set up an Azure Web App and deploy via GitHub Actions.2️⃣ AWS Deployment - Use Elastic Beanstalk or Lambda.3️⃣ Docker - Build and run the API in a container for portability.

📌 Future Enhancements

✔️ Connect to SQL Database using Entity Framework Core✔️ Implement JWT Authentication for security✔️ Add Logging & Exception Handling✔️ Improve UI with React / Angular frontend✔️ Deploy to Azure / AWS

📜 License

This project is licensed under the MIT License. Feel free to modify and distribute it.

🤝 Contributing

Want to contribute? Fork the repo, create a new branch, and submit a pull request! 🚀
