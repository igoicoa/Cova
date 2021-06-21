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

EXEC s_CrearPaciente 'Gonzalez', 'Juan', 32382278, '1987-02-21', 'jgonzalez@hotmail.com'
EXEC s_CrearPaciente 'Lopez', 'Pedro', 31938278, '1986-04-18', 'plopez@hotmail.com'
EXEC s_CrearPaciente 'Fernandez', 'Maria', 35263728, '1991-07-15', 'mfernandez@hotmail.com'
EXEC s_CrearProfesionalMedico 'Rojas', 'Daniel', 2593776, '1973-08-12', 'drojas@gmail.com', 123943, 643234, 'Neumonologia'
EXEC s_CrearProfesionalMedico 'Lopez', 'Ricardo', 16827367, '1968-10-15', 'rlopez@gmail.com', 382726, 293728, 'Cardiologia'
EXEC s_CrearProfesionalMedico 'Perez', 'Jose Luis', 28384374, '1981-05-21', 'jlperez@gmail.com', 382139, 284920, 'Pediatria'

-- Admin user
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