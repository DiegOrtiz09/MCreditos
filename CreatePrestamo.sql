CREATE TABLE Prestamo (
    PrestamoID INT IDENTITY(1,1) PRIMARY KEY,
    PersonaID INT FOREIGN KEY REFERENCES Personas(Id),
    CantidadPrestada DECIMAL(6, 2) NOT NULL,
    FechaPrestamo DATETIME NOT NULL,
    DiaCobro SMALLINT NOT NULL,
    MesesPrestamo INT NOT NULL,
    Intereses SMALLINT NOT NULL
);