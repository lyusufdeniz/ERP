
# SimpleERP 

SimpleERP is a **Clean Architecture** template for modern software development, built with .NET Core for the backend and Angular for the frontend. The project offers a modular and extensible design.

---

## Technologies Used

### Backend
- **.NET Core**, **EntityFrameworkCore**, **MediatR**, **AutoMapper**, **FluentValidation**

### Frontend
- **Angular**, **TypeScript**, **Bootstrap**

---

## Features

1. **User Management**: Prebuilt admin user (Username: `admin`, Password: `1`).
2. **Clean Architecture**: Four-layer structure (Domain, Application, Infrastructure, Presentation).
3. **Frontend Integration**: REST API powered by .NET Core, consumed by Angular.

---

## Setup Instructions

### 1. Clone the Repositories
 [https://github.com/lyusufdeniz/SimpleERP](https://github.com/lyusufdeniz/SimpleERP)


### 2. Install Dependencies
- Backend: Run `dotnet restore` in the backend directory.
- Frontend: Navigate to the frontend folder and run `npm install`.

### 3. Configure the Database
- Update **`appsettings.json`** with your connection string.
- Apply migrations: `dotnet ef database update`.

### 4. Run the Project
- **Backend**: `dotnet run`
- **Frontend**: `ng serve`

---

## Contribution

Contributions are welcome. Fork the repository, create a feature branch, and open a pull request.

---

## License

This project is licensed under the MIT License.
