# User Management API - .NET Backend Setup

## Overview

This README provides detailed steps to set up the .NET backend for the User Management API project, which involves integrating MongoDB and ensuring GDPR compliance. The backend is built using .NET Core and provides CRUD operations for user management.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0): Needed to build and run the .NET Core application.
- [MongoDB](https://www.mongodb.com/): You can use either a local instance or MongoDB Atlas for the database.
- [Visual Studio or VS Code](https://visualstudio.microsoft.com/): Recommended for editing and running the .NET application.

## Setup Instructions

### Step 1: Clone the Repository

Clone the backend repository to your local machine:

```bash
git clone https://github.com/jellysaini/user-management-api-mongodb.git
cd user-management-api-mongodb
```
### Step 2: Configure MongoDB:
For MongoDB Atlas, get your connection string and configure it in appsettings.json:

```bash
{
  "MongoDb": {
    "ConnectionString": "mongodb+srv://<username>:<password>@cluster0.mongodb.net/UserDb?retryWrites=true&w=majority",
    "Database": "UserDb"
  }
}

```
For Local MongoDB, use:
```bash
{
  "MongoDb": {
    "ConnectionString": "mongodb://localhost:27017",
    "Database": "UserDb"
  }
}
```
### Step 3: Restore dependencies and run the backend:

```bash
dotnet restore
dotnet run
```

### Step 4: The API should be running at http://localhost:5000.:
