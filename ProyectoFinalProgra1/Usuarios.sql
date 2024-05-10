create database Usuarios
use Usuarios

CREATE TABLE Usuarios
(
    Id_Usuarios int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre varchar(50) NULL,
    Usuario varchar(50) NULL,
    Contraseña varchar(50) NULL,
    Tipo_Usuario varchar(50) NULL
);

INSERT INTO Usuarios (Nombre, Usuario, Contraseña, Tipo_Usuario) VALUES
('Juan Pérez', 'juanperez', 'password123', 'Médico'),
('María García', 'mariagarcia', 'abc456', 'Enfermera'),
('Carlos López', 'carloslopez', 'qwerty', 'Administrativo');

