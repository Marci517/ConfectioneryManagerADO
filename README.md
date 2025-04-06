# Confectionery Management Application

This is a Windows Forms desktop application created for a university course. It connects to a Microsoft SQL Server database and allows users to interact with a confectionery (Cukrászda) management system. The application supports basic CRUD operations and user registration via a stored procedure.

## Features

- View a list of confectioneries with location filtering
- Delete confectionery records
- Update number of employees
- Register new users through stored procedure
- Connect with multiple roles (Guest, Manager, or custom credentials)

## Technologies

- C# (.NET Framework)
- Windows Forms (WinForms)
- Microsoft SQL Server
- ADO.NET for database operations

## Main Project Structure

- `Cukraszda`: Struct representing a confectionery
- `CukraszdakDAL`: Data access layer for confectionery operations
- `Helyszin`: Struct representing a location (county)
- `HelyszinekDAL`: Data access layer for location-related queries
- `DALGen`: Generic base class for database operations
- `Program.cs`: Application entry point