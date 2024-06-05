CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Direccion NVARCHAR(100),
    Telefono NVARCHAR(20)
);

CREATE TABLE Asunto (
    IdAsunto INT PRIMARY KEY IDENTITY(1,1),
    Descripcion NVARCHAR(255),
    Fecha DATE,
    IdCliente INT,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);
