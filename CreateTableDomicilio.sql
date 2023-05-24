create table Domicilio (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Direccion VARCHAR(255) NOT NULL DEFAULT(''),
    Ciudad VARCHAR(255) NOT NULL DEFAULT(''),
);