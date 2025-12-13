# 🚍 Control De AutoBus

![C#](https://img.shields.io/badge/C%23-%2314354C.svg?style=flat&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-%230081CC.svg?style=flat&logo=.net&logoColor=white)
![WinForms](https://img.shields.io/badge/WinForms-0078D7.svg?style=flat)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927.svg?style=flat&logo=microsoft-sql-server&logoColor=white)

Sistema de Control de Autobuses – Arquitectura Multicapa

Este proyecto es una aplicación de escritorio desarrollada en **C# (.NET / WinForms)** orientada a la gestión de autobuses, choferes, rutas y asignaciones. Aplica buenas prácticas de **ingeniería de software**, separación de responsabilidades, **arquitectura multicapa** y **patrones de diseño** ampliamente usados en entornos profesionales.

El objetivo principal es ofrecer una solución **escalable**, **mantenible** y **segura**, adecuada como proyecto académico avanzado o como base para un sistema empresarial real.

---

## 📋 Tabla de Contenidos

1. [Arquitectura del Sistema](#arquitectura-del-sistema)
   - [Capa de Presentación (UI)](#capa-de-presentación-ui)
   - [Capa de Dominio (Business / Application Layer)](#capa-de-dominio-business--application-layer)
   - [Capa de Infraestructura (Data / Persistence Layer)](#capa-de-infraestructura-data--persistence-layer)
2. [Configuración de Base de Datos](#configuración-de-base-de-datos)
3. [Scripts SQL](#scripts-sql)
4. [Inicialización de Datos (Database Seeding)](#inicialización-de-datos-database-seeding)
5. [Credenciales de Acceso por Defecto](#credenciales-de-acceso-por-defecto)
6. [Acceso a Datos](#acceso-a-datos)
7. [Autenticación y Roles](#autenticación-y-roles)

---

## 🏛 Arquitectura del Sistema

El sistema utiliza una **Arquitectura Multicapa (Layered Architecture)** organizada en tres proyectos principales:

### 💻 Capa de Presentación (UI)

**Proyecto:** `ControlDeAutoBus`

- Implementa el patrón **MVC (Model–View–Controller)**.
- Contiene **formularios WinForms**, controladores y componentes visuales.
- Responsable de:
  - Interacción con el usuario.
  - Validación básica de entradas.
  - Comunicación con la **capa de dominio** mediante servicios y controladores.

### ⚙️ Capa de Dominio (Business / Application Layer)

**Proyecto:** `ControlDeAutoBus.Domain`

Contiene:

- **Entities**: modelos de negocio.
- **Services**: lógica de negocio y reglas del sistema.
- **Request / Response**: contratos de comunicación entre capas.
- **SharedInterfaces**: interfaces de repositorios y servicios.
- **Helper**: utilidades compartidas (hash de contraseñas, validaciones, etc.).

Esta capa es **independiente** y no depende de la infraestructura ni de la interfaz gráfica, garantizando **bajo acoplamiento** y **alta cohesión**.

### 🗄 Capa de Infraestructura (Data / Persistence Layer)

**Proyecto:** `ControlDeAutoBus.Infrastructure`

- Responsable del acceso a datos y persistencia.
- Implementa el **Repository Pattern**.
- Todas las operaciones CRUD se realizan mediante **procedimientos almacenados**.
- Contiene:
  - **Repositories**: implementaciones concretas de los repositorios.
  - **QuerySql**: scripts SQL y lógica relacionada a base de datos.
  - **Database.cs**: configuración y gestión de la conexión.

---

## 🛠 Configuración de Base de Datos

La cadena de conexión se define en el archivo `appsettings.json` del proyecto de presentación:

```json
"Connection": "Data Source=NAMESERVER;Initial Catalog=DATABASE;Integrated Security=True;TrustServerCertificate=True;"
