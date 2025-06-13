# Module 02 - Basic CRUD | Módulo 02 - CRUD Básico

🇬🇧 **This module demonstrates basic Create, Read, Update, and Delete (CRUD) operations using Entity Framework Core.**  
🇪🇸 **Este módulo demuestra operaciones básicas de Crear, Leer, Actualizar y Eliminar (CRUD) usando Entity Framework Core.**

---

## ❓ What is CRUD? / ¿Qué es CRUD?

🇬🇧 CRUD stands for Create, Read, Update, and Delete—these are the four basic operations for managing data in a database.  
🇪🇸 CRUD significa Crear, Leer, Actualizar y Eliminar—estas son las cuatro operaciones básicas para gestionar datos en una base de datos.

---

## 📚 Topics / Temas

- 🇬🇧 All CRUD operations are demonstrated in the `Program.cs` file, using helper static classes for each operation.  
- 🇪🇸 Todas las operaciones CRUD se demuestran en el archivo `Program.cs`, usando clases estáticas auxiliares para cada operación.

  - AddExample: Add a record / Agregar un registro
  - GetExample: Read records / Leer registros
  - UpdateExample: Update a record / Actualizar un registro
  - DeleteExample: Delete a record / Eliminar un registro

---

## 🗂️ Project Structure / Estructura del proyecto

```
02-basic-crud/
│
├── Models/
│   └── Product.cs
├── Data/
│   └── AppDbContext.cs
└── Program.cs
```

---

## 🛠️ How to Run / Cómo ejecutar

```bash
dotnet run
```

---

## ⚙️ Prerequisites / Prerrequisitos

- 🇬🇧 .NET SDK installed  
  🇪🇸 Tener instalado el SDK de .NET

- 🇬🇧 Entity Framework Core and SQL Server provider added to your project  
  🇪🇸 Entity Framework Core y el proveedor de SQL Server agregados a tu proyecto

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

- 🇬🇧 The project is configured to use SQL Server LocalDB by default.  
  🇪🇸 El proyecto está configurado para usar SQL Server LocalDB por defecto.

- 🇬🇧 If you want to use an in-memory database for testing, change the `OnConfiguring` method in `AppDbContext.cs`.  
  🇪🇸 Si deseas usar una base de datos en memoria para pruebas, cambia el método `OnConfiguring` en `AppDbContext.cs`.

---

## 📄 Main Files / Archivos principales

- **Models/Product.cs**  
  🇬🇧 Defines the `Product` entity.  
  🇪🇸 Define la entidad `Product`.

- **Data/AppDbContext.cs**  
  🇬🇧 Configures the EF Core database context.  
  🇪🇸 Configura el contexto de base de datos de EF Core.

- **Program.cs**  
  🇬🇧 Contains the entry point and all CRUD operation examples, organized in static helper classes.  
  🇪🇸 Contiene el punto de entrada y todos los ejemplos de operaciones CRUD, organizados en clases auxiliares estáticas.

---

## ⚡ Database Initialization / Inicialización de la base de datos

- 🇬🇧 To create the database and apply migrations, use:  
  🇪🇸 Para crear la base de datos y aplicar migraciones, usa:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

🇬🇧 This module is a starting point for working with databases using Entity Framework Core.  
🇪🇸 Este módulo es un punto de partida para trabajar con bases de datos usando Entity Framework Core.