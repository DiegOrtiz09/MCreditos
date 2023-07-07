use MicroCreditos;
CREATE TABLE Personas (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(150) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50) NOT NULL,
    CantidadPrestada DECIMAL(6,2) NOT NULL,
    Telefono NVARCHAR(32),
    Email NVARCHAR(200) NOT NULL,
    FechaPrestamo DATETIME NOT NULL,
    DiaCobro SMALLINT NOT NULL,
    MesesPrestamo INT NOT NULL,
    Intereses SMALLINT NOT NULL
);