
# SimpleERP 

This project is a **Clean Architecture** template designed for modern software development, offering a modular and extensible foundation. Built with .NET Core, it incorporates several popular libraries to ensure scalability and maintainability.

---

## Technologies and Libraries Used

### Backend Technologies
- **EntityFrameworkCore**: ORM library for data access.
- **EntityFrameworkCore.Identity**: Provides built-in user management and authentication features.
- **MediatR**: Implements the CQRS (Command Query Responsibility Segregation) and Mediation patterns.
- **AutoMapper**: Simplifies object-to-object mapping.
- **FluentValidation**: Offers robust validation support for models and objects.
- **TS.Result**: Helps model operation results effectively.
- **TS.EntityFrameworkCore.GenericRepository**: Simplifies implementation of the repository pattern.

---

## Database Configuration

### Default Configuration
- The project is initially configured to use **MSSQL**.
- To continue using MSSQL, update the **`ConnectionStrings`** section in the **`appsettings.json`** file with your connection details:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;"
}
```

### Switching to Another Database
If you wish to use a different database:
1. Replace the NuGet package in the **Infrastructure** layer with the appropriate database provider.
2. Update the connection string in the **`appsettings.json`** file accordingly.
3. Ensure that migrations are updated before running the project.

---

## Features

### 1. User Management
- The project includes a pre-built structure for user management and authentication.
- Upon startup, the following **admin** user is created automatically:
  - **Username**: `admin`
  - **Password**: `1`
- A customizable **User** class is provided for extension.

### 2. Support for CQRS and Mediation Pattern
- All operations are organized into **Command** and **Query** layers using MediatR.
- This approach improves code maintainability and testability.

### 3. Modular Architecture
- The project follows **Clean Architecture** principles with four main layers:
  - **Domain**
  - **Application**
  - **Infrastructure**
  - **Presentation**
- Dependencies between layers are minimized.

---

## Setup Instructions

### 1. Clone the Repository
```bash
git clone https://github.com/lyusufdeniz/SimpleERP
```

### 2. Install Dependencies
Restore the dependencies by running the following command in the project directory:
```bash
dotnet restore
```

### 3. Configure the Database
- Update the **`appsettings.json`** file with your database connection details.
- Apply migrations to set up the database:
```bash
dotnet ef database update
```

### 4. Run the Project
```bash
dotnet run
```

---

## Project Structure

### 1. **Domain Layer**
- Contains business rules and core entities.
- Isolated from external dependencies.

### 2. **Application Layer**
- Contains business logic and use cases.
- Uses MediatR, AutoMapper, and FluentValidation.

### 3. **Infrastructure Layer**
- Handles data access, third-party services, and infrastructure-related concerns.

### 4. **Presentation Layer**
- Contains API or UI-related code.

---

## Code Quality and Best Practices

- Adheres to **SOLID** principles.
- Highly testable with unit tests for all features.
- Employs Dependency Injection (DI) for a flexible and decoupled architecture.

---

## Contribution

This project is open source, and contributions are welcome. Follow these steps to contribute:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m "Add your feature description"
   ```
4. Push your branch to your forked repository:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a **Pull Request**.

---

## License

This project is licensed under the MIT License. For more details, refer to the **LICENSE** file.

---

For any questions or feedback, feel free to reach out via [yd.yusufdeniz41@gmail.com](mailto:yd.yusufdeniz41@gmail.com). 😊
