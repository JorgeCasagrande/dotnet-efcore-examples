# Module 03 - Relationships | Módulo 03 - Relaciones

🇬🇧 **This module demonstrates how to define and work with relationships in Entity Framework Core:**  
- One-to-Many  
- Many-to-Many

🇪🇸 **Este módulo muestra cómo definir y trabajar con relaciones en Entity Framework Core:**  
- Uno a Muchos  
- Muchos a Muchos

---

## 📚 Topics / Temas

- 🇬🇧 Defining navigation properties and foreign keys  
  🇪🇸 Definir propiedades de navegación y claves foráneas
- 🇬🇧 Configuring relationships with Fluent API and Data Annotations  
  🇪🇸 Configurar relaciones con Fluent API y Data Annotations
- 🇬🇧 Querying related data (eager/lazy loading)  
  🇪🇸 Consultar datos relacionados (eager/lazy loading)
- 🇬🇧 Adding and removing related entities  
  🇪🇸 Agregar y eliminar entidades relacionadas

---

## 🗂️ Project Structure / Estructura del proyecto

```
03-relationships/
│
├── one-to-many/
│   ├── Models/
│   ├── Data/
│   └── Program.cs
│
└── many-to-many/
    ├── Models/
    ├── Data/
    └── Program.cs
```

---

## 🛠️ How to Run / Cómo ejecutar

```bash
# One-to-Many example
cd 03-relationships/one-to-many
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run

# Many-to-Many example
cd ../many-to-many
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

---

## ⚙️ Prerequisites / Prerrequisitos

- .NET SDK 6.0 or later
- EF Core CLI (`dotnet ef`)
- SQL Server LocalDB provider installed

### Required NuGet Packages / Paquetes NuGet requeridos

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

🇬🇧 Each subfolder contains a focused example for each relationship type.  
🇪🇸 Cada subcarpeta contiene un ejemplo enfocado para cada tipo de relación.