create database Usuarios
use Usuarios

CREATE TABLE Usuarios
(
    Id_Usuarios int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre varchar(50) NULL,
    Usuario varchar(50) NULL,
    Contrase�a varchar(50) NULL,
    Tipo_Usuario varchar(50) NULL
);

INSERT INTO Usuarios (Nombre, Usuario, Contrase�a, Tipo_Usuario) VALUES
('Juan P�rez', 'juanperez', 'password123', 'M�dico'),
('Mar�a Garc�a', 'mariagarcia', 'abc456', 'Enfermera'),
('Carlos L�pez', 'carloslopez', 'qwerty', 'Administrativo');


CREATE TABLE PACIENTES_BD (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    FechaNacimiento DATE,
    Genero NVARCHAR(10),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);

SELECT * FROM Pacientes;

SELECT * FROM bd_Pacientes;

ALTER TABLE Pacientes
ADD Edad INT;

ALTER TABLE PACIENTES_BD
ADD Edad INT;

CREATE TABLE bd_Pacientes (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Edad INT,
    FechaNacimiento DATE,
    Genero NVARCHAR(10),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);



