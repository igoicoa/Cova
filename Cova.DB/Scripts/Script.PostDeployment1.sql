/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Creo usuarios de prueba
EXEC s_CrearPaciente 'Gonzalez', 'Juan', 32382278, '1987-02-21', 'M', 'Soltero', '1123423452', 'jgonzalez@hotmail.com'
EXEC s_CrearPaciente 'Lopez', 'Pedro', 31938278, '1986-04-18', 'M', 'Soltero', '1123423452', 'plopez@hotmail.com'
EXEC s_CrearPaciente 'Fernandez', 'Maria', 35263728, '1991-07-15', 'M', 'Soltero', '1123423452', 'mfernandez@hotmail.com'
EXEC s_CrearProfesionalMedico 'Rojas', 'Daniel', 2593776, '1973-08-12', 'drojas@gmail.com', 'M', 'Soltero', '1123423452', 123943, 643234, 'Neumonologia'
EXEC s_CrearProfesionalMedico 'Lopez', 'Ricardo', 16827367, '1968-10-15', 'rlopez@gmail.com', 'M', 'Soltero', '1123423452', 382726, 293728, 'Cardiologia'
EXEC s_CrearProfesionalMedico 'Perez', 'Jose Luis', 28384374, '1981-05-21', 'jlperez@gmail.com', 'M', 'Soltero', '1123423452', 382139, 284920, 'Pediatria'

-- Creo el Admin user
DECLARE @UserIDAdmin BIGINT
DECLARE @permiso INT = 0;
INSERT INTO Usuario(Usuario, Password, UltimoLogin)
VALUES
--User: Admin
--Password: test123
('Admin', 'CC-03-E7-47-A6-AF-BB-CB-F8-BE-76-68-AC-FE-BE-E5', GETDATE());
SET @UserIDAdmin = SCOPE_IDENTITY();

WHILE @permiso < 48
BEGIN
   INSERT INTO [dbo].[UsuarioPermiso] (UsuarioID, TipoPermiso)
    VALUES
    (@UserIDAdmin, @permiso)
    SET @permiso = @permiso + 1;
END;

-- Multiidioma
DECLARE @IdiomaCastellanoId INT,
        @IdiomaInglesId INT,
        @EtiquetaId INT

INSERT INTO [dbo].[Idioma] (Nombre, [Default]) VALUES ('Castellano', 1)
SET @IdiomaCastellanoId = SCOPE_IDENTITY()

INSERT INTO [dbo].[Idioma] (Nombre, [Default]) VALUES ('English', 0)
SET @IdiomaInglesId = SCOPE_IDENTITY()

-- Guardo traduccion para etiqueta Usuario
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('usuario')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Usuario')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'User')

-- Guardo traduccion para etiqueta Nombre
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('nombre')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Nombre')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'Name')

-- Guardo traduccion para etiqueta apellido
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('apellido')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Apellido')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'Last Name')

-- Guardo traduccion para etiqueta menuinicio
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('menuinicio')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Inicio')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'Start')

-- Guardo traduccion para etiqueta menuiniciologin
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('menuiniciologin')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Iniciar Sesion')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'Login')

-- Guardo traduccion para etiqueta menuiniciologout
INSERT INTO [dbo].[Etiqueta] (Nombre) VALUES ('menuiniciologout')
SET @EtiquetaId = SCOPE_IDENTITY()
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaCastellanoId, @EtiquetaId, 'Cerrar Sesion')
INSERT INTO [dbo].[Traduccion] (IdiomaId, EtiquetaId, Traduccion)
VALUES
(@IdiomaInglesId, @EtiquetaId, 'Logout')

