	create table Contacto (
		ID int IDENTITY(1,1) PRIMARY KEY,
		Nombre varchar(50) not null DEFAULT '',
		Empresa  varchar(100) not null DEFAULT '',
		Imagen varchar(255) not null DEFAULT '',
		Email varchar(100) not null DEFAULT '',
		FechaNacimiento DateTime not null,
		Telefono varchar(12) not null DEFAULT '',
		Domicilio varchar(100) not null DEFAULT '',
	);