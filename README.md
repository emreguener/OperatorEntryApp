# OperatorEntryApp

This is a Windows Forms-based application developed during an internship at Haier Europe.

## Overview
OperatorEntryApp is a barcode logging and authentication system designed for factory personnel. It features:
- Login/Register with SHA-256 hashed passwords
- Role-based authorization (engineer, operator, supervisor)
- Product barcode entry with timestamp and supplier code
- SQL Server integration using ADO.NET
- Activity logging for auditability

## Technologies
- C# (.NET Framework 4.8)
- WinForms
- MSSQL (LocalDB / SQLExpress)
- ADO.NET
- Git

## Database Schema
- **Users**: UserId, FullName, Password, Role
- **UserInputs**: InputId, ProductBarcode, UserId (FK), Timestamp, SupplierCode
- **Logs**: LogId, UserId (FK), Action, Timestamp

## Setup
1. Restore the SQL Server database using `Haier_DB`
2. Adjust connection string in `App.config`
3. Open and run the solution file `OperatorEntryApp.sln` with Visual Studio

## Author
Developed by Emre Güner during 2025 internship at Haier Europe – Digitalization Department.
