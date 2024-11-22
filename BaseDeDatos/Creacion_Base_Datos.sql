-- Crear la base de datos
CREATE DATABASE PesajeInteligente;
GO

-- Usar la base de datos recién creada
USE PesajeInteligente;
GO

-- Crear la tabla Company
CREATE TABLE Company (
    EmpresaID INT PRIMARY KEY IDENTITY(1,1),  -- ID autonumérico
    Nombre NVARCHAR(100) NOT NULL,             -- Nombre de la empresa
    Codigo INT NOT NULL,                      -- Código de la empresa
    Direccion NVARCHAR(255),                  -- Dirección de la empresa
    Telefono NVARCHAR(20),                    -- Teléfono de la empresa
    Ciudad NVARCHAR(100),                     -- Ciudad
    Departamento NVARCHAR(100),               -- Departamento
    Pais NVARCHAR(100),                       -- País
    FechaCreacion DATETIME DEFAULT GETDATE(), -- Fecha y hora de creación
    FechaUltimaModificacion DATETIME DEFAULT GETDATE() -- Fecha y hora de última modificación
);
GO

-- Insertar datos en la tabla Company
INSERT INTO Company (Nombre, Codigo, Direccion, Telefono, Ciudad, Departamento, Pais, FechaCreacion, FechaUltimaModificacion)
VALUES 
('Tech Solutions', 1001, 'Av. 123, Tech City', '3001234567', 'Tech City', 'Tech Department', 'Techland', GETDATE(), GETDATE()),
('Innovative Industries', 1002, 'Calle Futura 456, Future City', '3012345678', 'Future City', 'Innovation Department', 'Futureland', GETDATE(), GETDATE()),
('Smart Corp', 1003, 'Calle Inteligente 789, Smart City', '3023456789', 'Smart City', 'Tech Department', 'Smartland', GETDATE(), GETDATE()),
('Green Tech', 1004, 'Calle Verde 101, Eco City', '3034567890', 'Eco City', 'Green Department', 'Ecoland', GETDATE(), GETDATE()),
('Digital Enterprises', 1005, 'Calle Digital 202, Digital City', '3045678901', 'Digital City', 'Digital Department', 'Digitaland', GETDATE(), GETDATE());
GO
