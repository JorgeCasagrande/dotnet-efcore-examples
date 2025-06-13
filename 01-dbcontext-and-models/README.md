# 01 - DbContext and Models

## 🌐 English

### 🎯 Goal

This example shows how to define a simple model class and a `DbContext` in Entity Framework Core using SQL Server LocalDB.

### 🧠 Key Concepts

- A **model** is a C# class that maps to a database table.
- The **DbContext** is the EF Core class responsible for interacting with the database (querying, saving, updating, etc.).
- EF Core uses **DbSet<T>** properties to represent tables.
- This example uses `EnsureCreated()` to automatically generate the database.

---

## 🇪🇸 Español

### 🎯 Objetivo

Este ejemplo muestra cómo definir una clase de modelo simple y un `DbContext` en Entity Framework Core usando SQL Server LocalDB.

### 🧠 Conceptos clave

- Un **modelo** es una clase C# que representa una tabla en la base de datos.
- El **DbContext** es la clase de EF Core encargada de interactuar con la base de datos (consultas, guardado, actualizaciones, etc.).
- EF Core usa propiedades `DbSet<T>` para representar tablas.
- Este ejemplo usa `EnsureCreated()` para generar la base automáticamente.

---

## ▶️ Run

```bash
dotnet run
