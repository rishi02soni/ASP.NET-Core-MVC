#  Expense Tracker - ASP.NET Core MVC

A complete Expense Tracker web application built using ASP.NET Core MVC and Entity Framework Core with SQLite database support. This project helps users manage daily expenses, track spending, categorize expenses, and monitor overall financial activity through a simple and responsive interface.

---

##  Project Overview

The Expense Tracker application allows users to:

- Add new expenses
- View all expenses
- Edit existing expenses
- Delete expenses
- Track total spending
- Organize expenses by category
- Store data in SQLite database
- Perform complete CRUD operations

This project follows the MVC (Model-View-Controller) architecture of ASP.NET Core.

---

## 🚀 Features

### User Features
```
- Add Expense  
- View Expense List  
- Update Expense Details  
- Delete Expenses  
- Track Total Expenses  
- Expense Categories  
- Responsive UI  
- SQLite Database Integration  
- Entity Framework Core Support  
- Input Validation  
```
---

## 🛠 Technologies Used

| Technology | Purpose |
|------------|---------|
| ASP.NET Core MVC | Backend Framework |
| C# | Programming Language |
| Entity Framework Core | ORM |
| SQLite | Database |
| Razor Views | Frontend UI |
| Bootstrap | Responsive Design |
| HTML/CSS | User Interface |

---

## 📂 Project Structure

```
ExpenseTracker/
│
├── Controllers/
│      ExpenseController.cs
│
├── Models/
│      Expense.cs
│
├── Data/
│      AppDbContext.cs
│
├── Views/
│      Expense/
│             Index.cshtml
│             Create.cshtml
│             Edit.cshtml
│
├── wwwroot/
│
├── appsettings.json
│
├── Program.cs
│
└── ExpenseTracker.csproj
```

---

## ⚙️ Installation Guide

### Step 1: Clone Project

```
git clone https://github.com/yourusername/ExpenseTracker.git
```

Move inside project folder:

```
cd ExpenseTracker
```

---

### Step 2: Install Dependencies

Run:

```
dotnet restore
```

Install Entity Framework packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

### Step 3: Create Database Migration

Create migration:

```
dotnet ef migrations add InitialCreate
```

Update database:

```bash
dotnet ef database update
```

---

### Step 4: Run Project

```
dotnet run
```

Open browser:

```
https://localhost:5001
```

or

```
http://localhost:5000
```

---

## 🗄 Database Configuration

Connection string inside:

**appsettings.json**

```json
{
   "ConnectionStrings": {
      "DefaultConnection":"Data Source=expense.db"
   }
}
```

---

## 📋 Expense Model

Fields used:

| Property | Data Type |
|----------|-----------|
| Id | Integer |
| Title | String |
| Category | String |
| Amount | Decimal |
| Date | DateTime |

---

## 🔄 CRUD Operations

### Create

Users can add expenses including:

- Expense Title
- Category
- Amount
- Date

### Read

Displays:

- Expense list
- Total expenses
- Categories

### Update

Users can edit existing expense details.

### Delete

Users can remove expenses permanently.

---

## MVC Workflow

### Model

Responsible for:

- Database entities
- Data validation
- Business rules

### View

Responsible for:

- Displaying UI
- Forms
- Tables

### Controller

Responsible for:

- Processing requests
- Connecting Models and Views
- Business logic

---

## Example User Flow

1. User opens application

2. Dashboard appears

3. User clicks:

```text
Add Expense
```

4. User enters:

```text
Title: Food
Category: Personal
Amount: 250
Date: 25-05-2026
```

5. Expense saves into database

6. Updated expense list appears

---

## Future Improvements

- User Authentication
- Login and Registration
- Dashboard Analytics
- Pie Charts
- Monthly Reports
- Export PDF
- Export Excel
- Budget Limits
- Dark Mode
- AI Spending Insights
- Email Notifications

---

## Screenshots

Add screenshots here:

```md
![Home](images/home.png)

![Create](images/create.png)

![Dashboard](images/dashboard.png)
```

---

## Learning Outcomes

Through this project:

- Understand ASP.NET Core MVC
- Learn Entity Framework Core
- Work with SQLite database
- Implement CRUD operations
- Build responsive web applications
- Apply MVC architecture

---

## Author

**Rishi Soni**

---

## License

This project is licensed under the MIT License.

---

⭐ If you found this useful, consider giving the repository a star.
