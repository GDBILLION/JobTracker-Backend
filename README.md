# 🖥️ JobTracker Pro - .NET 8 REST API

A robust, enterprise-grade backend service built with **ASP.NET Core** and **Entity Framework Core**. This API manages the lifecycle of job applications, providing a secure and scalable data layer for the JobTracker frontend.

## 🧱 The Backend Build Journey (Bricks 1-7)

* **Brick 1: Environment & SDK Setup** - Initialized the .NET 8 Web API project.
* **Brick 2: Domain Modeling** - Defined the `JobApplication` entity and schema.
* **Brick 3: Database & Migrations** - Successfully implemented EF Core migrations for "JobTrackerDb".
* **Brick 4: DTO Pattern (Data Transfer Objects)** - Implemented DTOs to decouple the API contract from the database schema. This ensures only necessary data is sent to the frontend, improving security and performance.
* **Brick 5: Repository Pattern Implementation** - Developed the `IJobRepository` interface to decouple data access logic from the API controllers.
* **Brick 6: Dependency Injection & Controllers** - Configured the .NET Service Container and engineered the `ApplicationsController` for RESTful CRUD operations.
* **Brick 7: Cross-Origin Resource Sharing (CORS)** - Implemented a secure `DevCorsPolicy` to facilitate the "handshake" between the .NET backend and the React frontend.

## 🛠️ Tech Stack
* **Framework:** ASP.NET Core 8.0
* **Data Access:** Entity Framework Core (SQL Server)
* **Design Patterns:** Repository Pattern, DTO (Data Transfer Object)
* **API Documentation:** Swagger / OpenAPI
