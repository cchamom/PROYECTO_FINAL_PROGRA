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

