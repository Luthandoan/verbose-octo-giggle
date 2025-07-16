# Gym Management System

The application is a Windows-based system built with **Windows Forms**, **ADO.NET**, and **SQL Server**, designed to help gym staff manage member records, classes, training programs, and user authentication efficiently.

---

## 📌 Project Overview

The Gym Management System provides a graphical interface for gym staff to:
- Log in securely using a username and password stored in a **text file**
- Perform full **CRUD operations** on members, classes, and training programs
- Handle class schedules and instructor assignments
- Search for specific members or view members by assigned instructor
- Ensure secure, validated, and persistent data management

---

## 🧩 Key Features

### 1. 🔐 User Authentication
- Login form with validation
- Credentials stored in a **text file**
- Account lockout after 3 failed attempts
- Admin functionality to unlock user accounts

### 2. 🧑‍💼 Member Management
- Add, view, update, and delete member details
- Member data includes: name, DOB, gender, contact info, training program, and membership duration
- Search by ID or name
- View all members assigned to a specific instructor

### 3. 📋 Class and Training Program Management
- Add and manage programs with:
  - ID, Name, Description, Instructor, Schedule, Capacity, and Duration
- CRUD operations on class/program records
- Search and filter options

### 4. 🗂 GUI Design and Usability
- Built using **Windows Forms** in **Visual Studio**
- Intuitive and clean user interface for easy navigation
- Uses **DataGridView** and **ListView** for data display

### 5. 🛠 Technologies Used
| Technology      | Purpose                                      |
|-----------------|----------------------------------------------|
| C#              | Core application logic                        |
| Windows Forms   | Graphical User Interface                     |
| SQL Server      | Relational database backend                  |
| ADO.NET         | Data access and database connectivity        |
| Text File I/O   | Login data storage and account locking       |

---

## 💾 Database and File Handling

- Uses **ADO.NET** to connect to a local **SQL Server** database
- Member and class details stored in normalized tables
- Stored procedures used for optimized CRUD operations
- Custom **FileHandling** class to read/write login credentials

---

## ⚠️ Error Handling & Validation

- All inputs validated for correctness
- Proper use of `try-catch` blocks and meaningful messages
- Custom exceptions implemented for specific scenarios (e.g., duplicate ID, invalid data)

---

## 🔎 Search & Filter Features

- Search members by name or ID
- Filter members based on assigned instructor
- Real-time results displayed in the data grid
