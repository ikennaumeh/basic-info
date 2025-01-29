# Basic Info API

This is a simple public API built with **ASP.NET Core Web API** that returns the following information in **JSON format**:
- Your registered email on the HNG12 Slack workspace.
- The current datetime in ISO 8601 format.
- The GitHub URL of the project's codebase.

## 🚀 Getting Started

### Prerequisites
Ensure you have the following installed on your system:
- [.NET 8+ SDK](https://dotnet.microsoft.com/download)
- Git
- A terminal or command prompt

### Installation & Setup
1. Clone this repository:
   ```sh
   git clone https://github.com/ikennaumeh/basic-info.git
   cd your-repo
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Run the API locally:
   ```sh
   dotnet run
   ```

By default, the API runs on:
```
http://localhost:<port-number>/api/Infomation
```

---

## 📌 API Documentation

### **Endpoint:** Get Public Info
- **URL:** `/api/Infomation`
- **Method:** `GET`
- **Response Format:** `application/json`

#### **Response Example**
```json
{
  "email": "kennaumeh@gmail.com",
  "date_time": "2025-01-29T13:17:55.2917290Z",
  "github_url": "https://github.com/ikennaumeh/basic-info"
}
```

---

## 🔗 Related Links
Looking to hire **C# developers**? Check out:
[https://hng.tech/hire/csharp-developers](https://hng.tech/hire/csharp-developers)

---

## 📜 License
This project is open-source under the **MIT License**.

