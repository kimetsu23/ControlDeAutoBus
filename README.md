# Control De AutoBus

Sistema de Control de Autobuses – Arquitectura Multicapa

Este proyecto es una aplicación de escritorio desarrollada en C# (.NET / WinForms) orientada a la gestión de autobuses, choferes, rutas y asignaciones. El sistema ha sido construido aplicando buenas prácticas de ingeniería de software, separación de responsabilidades, arquitectura multicapa y patrones de diseño ampliamente utilizados en entornos profesionales.

El objetivo principal es ofrecer una solución escalable, mantenible y segura, adecuada como proyecto académico avanzado o como base para un sistema empresarial real.

Arquitectura del Sistema

El sistema está estructurado utilizando una Arquitectura Multicapa (Layered Architecture), organizada en tres proyectos principales:

Capa de Presentación (UI)

Proyecto: ControlDeAutoBus

Implementa el patrón MVC (Model–View–Controller).

Contiene formularios WinForms, controladores y componentes visuales.

Responsable de:

Interacción con el usuario.

Validación básica de entradas.

Comunicación con la capa de dominio mediante servicios y controladores.

Capa de Dominio (Business / Application Layer)

Proyecto: ControlDeAutoBus.Domain

Contiene:

Entities: modelos de negocio.

Services: lógica de negocio y reglas del sistema.

Request / Response: contratos de comunicación entre capas.

SharedInterfaces: interfaces de repositorios y servicios.

Helper: utilidades compartidas (hash de contraseñas, validaciones, etc.).

Esta capa es independiente y no depende de la infraestructura ni de la interfaz gráfica, garantizando bajo acoplamiento y alta cohesión.

Capa de Infraestructura (Data / Persistence Layer)

Proyecto: ControlDeAutoBus.Infrastructure

Responsable del acceso a datos y persistencia.

Implementa el Repository Pattern.

Todas las operaciones CRUD se realizan exclusivamente mediante procedimientos almacenados.

Contiene:

Repositories: implementaciones concretas de los repositorios.

QuerySql: scripts SQL y lógica relacionada a base de datos.

Database.cs: configuración y gestión de la conexión.

Configuración de Base de Datos

La cadena de conexión se define en el archivo appsettings.json del proyecto de presentación:

"Connetion": "Data Source=NAMESERVER;Initial Catalog=DATABASE;Integrated Security=True;TrustServerCertificate=True;"

Configuración obligatoria

El archivo appsettings.json debe tener configurada la propiedad:

Copiar al directorio de salida: Copiar siempre

Esto es indispensable para que la aplicación pueda leer la cadena de conexión correctamente en tiempo de ejecución.

Scripts SQL

En la carpeta ControlDeAutoBus.Infrastructure/QuerySql se incluyen los scripts necesarios para inicializar la base de datos:

Un script con la base de datos completa.

Dos scripts separados:

Creación de tablas.

Creación de procedimientos almacenados.

Esta separación permite cambiar fácilmente el nombre de la base de datos sin afectar la estructura ni la lógica del sistema.

Antes de ejecutar la aplicación es obligatorio:

Crear la base de datos.

Ejecutar los scripts SQL correspondientes.

Inicialización de Datos (Database Seeding)

El sistema incluye una clase de inicialización de datos (DatabaseSeeder) que se encarga de:

Crear los roles del sistema si no existen:

Admin

Chofer

Usuario

Crear un usuario administrador por defecto si no existe en la base de datos.

Este proceso garantiza que el sistema pueda ser utilizado inmediatamente después de su instalación.

Credenciales de Acceso por Defecto

Una vez ejecutado el seeding de la base de datos, el sistema contará con el siguiente usuario administrador:

Usuario: admin

Clave: Admin123

Rol: Administrador

La contraseña se almacena de forma segura utilizando hash mediante la clase PasswordHasher.

Acceso a Datos

La clase Database centraliza la lectura de la cadena de conexión desde appsettings.json y gestiona el acceso a la base de datos, siguiendo un enfoque de instancia única (Singleton implícito) para evitar múltiples conexiones innecesarias.

Los repositorios están separados por entidad, existiendo múltiples repositorios independientes, cada uno responsable de su propio contexto de datos.

#Autenticación y Roles

El sistema implementa autenticación con control de acceso por roles:

Administrador

Registro y gestión de choferes, rutas y autobuses.

Usuario

Asignación de choferes, autobuses y rutas.

Chofer

Rol reservado para futuras extensiones del sistema.
