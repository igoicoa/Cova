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

-- Creo las Coberturas Medicas con sus Planes
INSERT INTO [dbo].[CoberturaMedica] (Nombre)
VALUES
('AVALIAN'),
('GALENO'),
('MEDICUS'),
('MEDIFE'),
('OMINT'),
('OSDE'),
('SANCOR SALUD'),
('SWISS MEDICAL')

INSERT INTO [dbo].[CoberturaMedicaPlan] (CoberturaMedicaId, Nombre)
VALUES
-- AVALIAN
(1, 'Plan Integral'),
(1, 'Plan Superior'),
(1, 'Plan Selecta'),
-- GALENO
(2, '220'),
(2, '330'),
(2, '440'),
(2, '550'),
-- MEDICUS
(3, 'Plan Azul'),
(3, 'Plan Celeste'),
(3, 'Plan One'),
(3, 'Plan One R'),
(3, 'Plan Integra'),
-- MEDIFE
(4, 'Plan Bronce'),
(4, 'Plan Juntos'),
(4, 'Plan Plata'),
(4, 'Plan Oro'),
(4, 'Plan Platinum'),
-- OMINT
(5, 'Genesis'),
(5, 'Global'),
(5, 'Clasico'),
(5, 'Premium'),
-- OSDE
(6, 'OSDE 210'),
(6, 'OSDE 310'),
(6, 'OSDE 410'),
(6, 'OSDE 450'),
(6, 'OSDE 450'),
-- SANCOR SALUD
(7, 'SanCor 700A'),
(7, 'SanCor 800V'),
(7, 'SanCor 1000'),
(7, 'SanCor 1500'),
(7, 'SanCor 3000'),
(7, 'SanCor 3500'),
(7, 'SanCor 4000'),
(7, 'SanCor 4500'),
(7, 'SanCor 5000 Exclusive'),
(7, 'SanCor 6000 Exclusive'),
-- SWISS MEDICAL
(8, 'Advance'),
(8, 'Global'),
(8, 'Premium'),
(8, 'Black')

-- Creo usuarios de prueba
-- Pacientes (PWD: paciente123)
EXEC s_CrearPaciente 'Gonzalez', 'Juan', 32382278, '1987-02-21', 'M', 'Soltero', '1123423452', 'jgonzalez@hotmail.com','San Martin',123,'','Quilmes','Buenos Aires','Argentina', 5, 1, '1234323424', '2023-01-02','B6-0F-15-38-5B-90-5B-E9-C9-77-C5-9A-A3-42-0F-D2'
EXEC s_CrearPaciente 'Lopez', 'Pedro', 31938278, '1986-04-18', 'M', 'Soltero', '1126376283', 'plopez@hotmail.com','Belgrano',2342,'2 A','CABA','CABA','Argentina', 8, 2, '302229329382834', '2022-08-01','B6-0F-15-38-5B-90-5B-E9-C9-77-C5-9A-A3-42-0F-D2'
EXEC s_CrearPaciente 'Fernandez', 'Maria', 35263728, '1991-07-15', 'F', 'Soltera', '1126399837', 'mfernandez@hotmail.com','Ciudad de la Paz',3321,'3 B','CABA','CABA','Argentina', 6, 2, '2736352637483', '2023-04-01','B6-0F-15-38-5B-90-5B-E9-C9-77-C5-9A-A3-42-0F-D2'
-- Medicos (PWD: medico123)
EXEC s_CrearProfesionalMedico 'Rojas', 'Daniel', 2593776, '1973-08-12', 'M', 'Casado', '1126352435','drojas@gmail.com','Lavalle',1453,'6 C','CABA','CABA','Argentina', 123943, 643234, 'Neumonologia','D7-A3-95-61-4E-B5-F8-8F-59-5D-4A-DA-63-89-48-F9'
EXEC s_CrearProfesionalMedico 'Lopez', 'Ricardo', 16827367, '1968-10-15', 'M', 'Casado', '1125333826','rlopez@gmail.com','9 de Julio',1242,'','Vicente Lopez','Buenos Aires','Argentina', 382726, 293728, 'Cardiologia','D7-A3-95-61-4E-B5-F8-8F-59-5D-4A-DA-63-89-48-F9'
EXEC s_CrearProfesionalMedico 'Perez', 'Jose Luis', 28384374, '1981-05-21', 'M', 'Casado', '1128372634','jlperez@gmail.com','Sarmiento',2817,'','Tigre','Buenos Aires','Argentina', 382139, 284920, 'Pediatria','D7-A3-95-61-4E-B5-F8-8F-59-5D-4A-DA-63-89-48-F9'
-- Enfermeros (PWD: enfermero123)
EXEC s_CrearProfesionalEnfermero 'Vargas', 'Pablo', 29327384, '1982-07-30', 'M', 'Soltero', '1182533324','pvargas@gmail.com','Palaa',2134,'','Avellaneda','Buenos Aires','Argentina', 29182736,'0E-C2-CB-0E-1D-1A-7C-5B-2A-CB-1C-2E-B3-8B-08-20'
EXEC s_CrearProfesionalEnfermero 'Salas', 'Sofia', 34928392, '1989-09-21', 'F', 'Soltera', '1182736253','ssalas@hotmail.com','Roca',213,'','Munro','Buenos Aires','Argentina', 38292832,'0E-C2-CB-0E-1D-1A-7C-5B-2A-CB-1C-2E-B3-8B-08-20'
-- Admin User (User: Admin - PWD: test123)
DECLARE @UserIDAdmin BIGINT
DECLARE @permiso INT = 0;
INSERT INTO Usuario(Usuario, Password, UltimoLogin)
VALUES
('Admin', 'CC-03-E7-47-A6-AF-BB-CB-F8-BE-76-68-AC-FE-BE-E5', GETDATE());
SET @UserIDAdmin = SCOPE_IDENTITY();

WHILE @permiso < 48
BEGIN
   INSERT INTO [dbo].[UsuarioPermiso] (UsuarioID, TipoPermiso)
    VALUES
    (@UserIDAdmin, @permiso)
    SET @permiso = @permiso + 1;
END;

-- DICCIONARIO MULTI IDIOMA
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

