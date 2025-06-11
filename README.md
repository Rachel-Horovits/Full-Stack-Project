# Eye Clinic Management System

A full-stack management system for an eye clinic, built with ASP.NET Core (.NET 8) and React.

---

## Table of Contents

- [About](#about)
- [Technologies](#technologies)
- [Setup & Run](#setup--run)
- [Project Structure](#project-structure)
- [Main Features](#main-features)
- [Security](#security)
- [Contributing](#contributing)

---

## About

This project is a management system for an eye clinic, supporting appointment scheduling, patient and doctor management, registration, login, and filtering appointments by doctor or specialty.

---

## Technologies

- **Backend:** ASP.NET Core 8, C#
- **Frontend:** React, Material-UI
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **Security:** JWT Token, CORS

---

## Setup & Run

### Prerequisites

- .NET 8 SDK
- Node.js (for React)
- SQL Server

### Steps

1. **Backend (Server):**
   - Open the solution in Visual Studio.
   - Update the database connection string in `appsettings.json`.
   - Run the project (`F5` or `dotnet run`).

2. **Frontend (Client):**
   - Navigate to the `client` directory.
   - Install dependencies:  
     `npm install`
   - Start the development server:  
     `npm start`

3. **Database:**
   - Run the provided SQL scripts to create tables and seed demo data.

---

## Project Structure

---

## Main Features

- Appointment management (add, view, filter)
- Login and registration with token
- Doctor and patient management
- Filter appointments by specialty/doctor
- API protection with JWT
- CORS support

---

## Security

- Login with JWT token
- Basic role-based authorization (future extension)
- API protection with CORS

---

## Contributing

Pull requests, suggestions, and bug reports are welcome!


---
