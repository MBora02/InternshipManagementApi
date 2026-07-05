# 🚀 Internship Management API

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)](#)
[![.NET Core](https://img.shields.io/badge/.NET-10.0-blue.svg)](https://dotnet.microsoft.com/en-us/)
[![Database](https://img.shields.io/badge/database-SQL%20Server-red.svg)](#)
[![API Documentation](https://img.shields.io/badge/docs-Scalar-orange.svg)](#)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

An enterprise-ready, robust backend Web API service built on **ASP.NET Core 10.0**. This API provides a centralized management system for student internships, bridging academic institutions, students, and companies. It handles CRUD operations for tracking participating companies, managing student directories, logging internship durations/statuses, and managing periodic student report submissions.

---

## 🛠️ Technology Stack

| Layer | Technology | Details / Description |
| :--- | :--- | :--- |
| **Core Framework** | .NET 10.0 / ASP.NET Core Web API | High-performance, cross-platform framework for building modern cloud-based APIs. |
| **Database Engine** | Microsoft SQL Server | Relational database management system for storing enterprise transactional data. |
| **ORM / Data Access** | Entity Framework Core 10.0 | Code-First database mapping and data access orchestration. |
| **API Documentation** | Scalar OpenAPI UI | Modern, interactive API rendering and testing platform integrated via `Scalar.AspNetCore`. |
| **Language** | C# 14 | Strong-typed object-oriented programming language. |

### Key Libraries & Packages
*   `Microsoft.EntityFrameworkCore.SqlServer` (v10.0.9) - Provider for SQL Server connections.
*   `Microsoft.EntityFrameworkCore.Tools` (v10.0.9) - CLI command-line tools for EF migrations.
*   `Microsoft.AspNetCore.OpenApi` (v10.0.9) - Built-in OpenAPI metadata support.
*   `Scalar.AspNetCore` (v2.16.4) - The replacement layout for interactive documentation.

---

## ✨ Key Features

*   **Student Directory**: Complete profile records for student participants including full name, department, email, and phone contact information.
*   **Company Management**: Catalog of internship providers segmented by sector, city, and telephone contacts.
*   **Internship Workflow Tracking**: Connects students to companies, tracking starting and completion dates alongside active status fields (`Active`, `Pending`, `Completed`).
*   **Periodic Report Registry**: System for interns to register written internship logs, storing timestamps, content descriptions, and review/approval statuses.
*   **Scalar OpenAPI Explorer**: In-browser endpoint testing suite directly integrated into the application pipeline for developers.

---

## 🏗️ Architecture & Folder Structure

The project implements a clean **Model-View-Controller (MVC) REST API** architecture layout (without Views). It leverages a dedicated DbContext layer for database interaction using the EF Core Code-First pattern.

```
InternshipManagementApi/
│
├── InternshipManagementApi.slnx        # Solution file (modern Visual Studio solution file format)
│
├── InternshipManagementApi/            # Main Web API Project directory
│   ├── Controllers/                    # API Endpoints (Student, Company, Internship, Report controllers)
│   ├── Migrations/                     # Entity Framework database schema migration files
│   ├── Models/                         # App DbContext and database schema models
│   ├── Properties/                     # Application profile settings (launchSettings.json)
│   ├── Program.cs                      # Main entrypoint, services configuration, and middleware pipeline
│   ├── appsettings.json                # Global settings & Database Connection String config
│   ├── appsettings.Development.json    # Local development override configuration
│   └── InternshipManagementApi.csproj  # Target framework definition and dependencies config
│
└── project6 codefirstapi ef/           # Project resources / placeholder folder
```

---

## ⚙️ Setup & Installation Guide

### Prerequisites
Make sure you have the following installed on your machine:
*   [.NET 10.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or higher.
*   [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express / Developer Edition) or SQL Server LocalDB.
*   EF Core CLI Tools: Install globally using:
    ```bash
    dotnet tool install --global dotnet-ef
    ```

### 1. Database Configuration
Update the database connection string to point to your SQL Server instance. Open [appsettings.json](file:///c:/Users/Bora/Desktop/InternshipManagementApi/InternshipManagementApi/appsettings.json) and locate the `ConnectionStrings` section:

```json
"ConnectionStrings": {
  "Default": "Server=YOUR_SERVER_NAME;Database=InternshipManagementDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
> [!NOTE]
> By default, the API is configured to connect to `DESKTOP-74G97I3\SQLEXPRESS` using Windows Authentication.

### 2. Run Database Migrations
Use EF Core CLI to apply migrations to your database. This will create the database `InternshipManagementDb` and all requisite tables (`Students`, `Companies`, `Internships`, `Reports`):

```bash
# Navigate to the project folder
cd InternshipManagementApi

# Run migration to update the target database
dotnet ef database update
```

### 3. Build & Run the API
To compile the codebase and run the HTTP server:

```bash
# Build the application
dotnet build

# Start the Web API server
dotnet run
```

The application will start and output its listening URLs. By default, these are:
*   **HTTPS Protocol**: `https://localhost:7129`
*   **HTTP Protocol**: `http://localhost:5085`

### 4. Interactive API Documentation
Once running, you can explore, query, and test the endpoints directly through your web browser using **Scalar**:
*   Documentation endpoint: `https://localhost:7129/scalar/v1`

### Default Authentication Credentials
> [!IMPORTANT]
> The current API endpoints are public and do not enforce authentication middleware, allowing developers to execute quick integration testing. No default login credentials are required.

---

## 📄 License & Attribution

This project is licensed under the MIT License - see the LICENSE file for details.
