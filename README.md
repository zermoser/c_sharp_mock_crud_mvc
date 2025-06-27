# ProductApiMvc

A simple .NET 8 Web API project using the MVC pattern with in-memory data storage (no real database). Supports full CRUD operations for a `Product` entity.

## Features

- .NET 8 Web API
- MVC Architecture (Controller - Service - Repository - Model)
- In-memory data (no external DB or file I/O)
- Swagger UI for testing APIs
- Ready to run with `dotnet run`
- Auto-launch Swagger when running from Visual Studio

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)

### Run the project

```bash
dotnet restore
dotnet run
```

Then navigate to:

```
https://localhost:49890/   (or your launch URL)
```

Swagger UI will open automatically if using Visual Studio with `launchSettings.json`.

---

## API Endpoints

| Method | Endpoint            | Description         |
|--------|---------------------|---------------------|
| GET    | /api/products       | Get all products    |
| GET    | /api/products/{id}  | Get product by ID   |
| POST   | /api/products       | Create new product  |
| PUT    | /api/products/{id}  | Update product      |
| DELETE | /api/products/{id}  | Delete product      |

---

## Sample Product Model

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

---

## Notes

- All data is stored in a static list in memory.
- No database or file system is required.
- Safe to restart without needing setup.

---

## License

This project is open-source and free to use.
