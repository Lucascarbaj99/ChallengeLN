create table Contacto (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL DEFAULT(''),
    Empresa VARCHAR(100) NOT NULL DEFAULT(''),
    Imagen VARCHAR(255) NOT NULL DEFAULT(''),
    Email VARCHAR(100) NOT NULL DEFAULT(''),
    FechaNacimiento DATETIME NOT NULL DEFAULT(''),
    Telefono VARCHAR(12) NOT NULL DEFAULT(''),
    DomicilioId INT NULL,
    CONSTRAINT FK_Contacto_Domicilio FOREIGN KEY (DomicilioId) REFERENCES Domicilio(Id)
);	