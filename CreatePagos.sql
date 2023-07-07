use MicroCreditos
CREATE TABLE Pagos (
    Id INT PRIMARY KEY,
    PersonaId INT,
    Monto DECIMAL(6,2) NOT NULL,
    PeriodoPago INT NOT NULL,
    FechaPago DATETIME NOT NULL,
    Estado BIT NOT NULL,
    CONSTRAINT FK_Pagos_Personas FOREIGN KEY (PersonaId)
        REFERENCES Personas (Id)
);