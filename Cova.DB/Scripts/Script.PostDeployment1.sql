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

--Laboratorio
INSERT INTO [dbo].[Laboratorio] ( Nombre, Pais, Email, Telefono)
VALUES
('Laboratorio Municipal de Olavarría','Argentina', 'dario.fontana@olavarria.gov.ar', 440803),
('Laboratorio del Hospital Municipal San Luis de Bragado','Argentina', ' ', 02342422210),
('Laboratorio Universidad de La Plata','Argentina', 'erbenmf@gmail.com', 4236701),
('INTI- Instituto Nacional de Tecnología Industrial','Argentina', ' ', 47246200),
('Instituto Nacional de Producción de Biológicos','Argentina', 'institPasteur@gmail.com', 48031732),
('Cephalon, Inc','EEUU', 'Cephalon@gov.com', 56663526),
('AstraZeneca International','EEUU', 'Astraz@gmail.com ', 58947363),
('Pfizer Inc','EEUU', 'Phizer@hotmail.com ', 55674839),
('Sigma-Tau Pharmaceuticals, Inc.','EEUU', ' ', 27465839)

--Vacunas
INSERT INTO [dbo].[Vacuna](Nombre, Descripcion, Prospecto, Contraindicaciones, CantidadDosis, LaboratorioID, EdadMinimaAplicacion, EdadMaximaAplicacion)
VALUES
('BCG','La tuberculosis es una infección que, en la mayoría de los casos, ataca a los pulmones, pero en los niños afecta a otros órganos, como el cerebro. Un caso grave podría acarrear serias complicaciones o causar la muerte.', 'Si padece tuberculosis o cualquier otra enfermedad infecciosa (activa o durante su convalecencia) o si está en tratamiento antituberculosis.Si padece algún trastornos de inmunidad, fundamentalmente en pacientes con infección por VIH, en niños nacidos de madres seropositivas, en casos de inmunodeficiencia congénita, o casos con la respuesta inmune disminuida por la acción de ciertos medicamentos (corticoides, agentes alquilantes, antimetabolitos) o la radiación.', 'En general, esta vacunación no suele causar fiebre o malestar. Algunos días después de la vacunación se desarrolla un nódulo de induración (abultamiento endurecido de tejido que se forma en la piel) en el sitio de la inyección. Este nódulo disminuye gradualmente y es reemplazado por una lesión local que puede ulcerarse algunas semanas más tarde. La lesión local no requiere tratamiento ni deben utilizarse apósitos. Esta lesión cura espontáneamente con formación de una pequeña costra negruzca.', 1, 2, 18, 99),
('HepB','La hepatitis B es una enfermedad del hígado contagiosa causada por el virus de la hepatitis B. Se refiere a los primeros 6 meses después de que se contrae el virus.', 'El principio activo es la cubierta externa del virus de la hepatitis B. Cada dosis contiene 20 microgramos/1 ml de proteína compuesta por esta cubierta externa adsorbida en hidróxido de aluminio hidratado.', 'Usted ha tenido una grave reacción alérgica a una dosis previa de la vacuna contra la hepatitis B', 4, 6, 10, 99),
('DTP Difteria','La difteria infecta la garganta y las amígdalas y, como consecuencia, a los niños que la padecen les cuesta respirar y tragar. Los casos graves pueden ocasionar daños en el corazón, los riñones y/o los nervios.', 'También puede haber malestar, irritabilidad y fiebre de 38.5º C por 12 o 24 horas (después de 48 horas generalmente corresponde a otra causa) y crisis convulsivas asociadas a fiebre. Pueden aparecer ronchas, que también desaparecen.', 'Tener una enfermedad grave, con o sin fiebre; tener temperatura mayor de 38°C. En cuanto se resuelvan estos problemas se podrá aplicar la vacuna.', 5, 3, 12, 99),
('Poliomielitis','La poliomielitis es un virus que paraliza a 1 de cada 200 personas que lo contraen. De esos casos, entre el 5% y el 10% mueren por la parálisis de los músculos respiratorios.', 'El enrojecimiento, malestar, inflamación y sensibilidad donde se puso la vacuna es común después de DTaP.','Las diferentes vacunas frente a la poliomielitis pueden tener en su composición excipientes como: formaldehido, fenoxietanol, polisorbato 80, trometamol, hidróxido  de aluminio, cloruro de magnesio, sacarosa o aminoácidos esenciales entre otros. ', 2, 4, 10, 99),
('DTP Tetanos','El tétanos provoca contracciones musculares muy dolorosas. Puede causar rigidez en el cuello y la mandíbula de los niños (trismo), impidiéndoles abrir la boca, tragar (o amamantar) o respirar.  Incluso con tratamiento, el tétanos suele ser mortal.', 'La vacuna Td puede administrarse como inmunización primaria a partir de los 7 años de edad. Se utilizan dos dosis de 0,5 ml de Td adsorbido con dosis reducida de componente antidiftérico para adultos con un intervalo mínimo de cuatro semanas. Se recomienda una tercera dosis por lo menos seis meses después de la segunda dosis.', 'No se debe volver a administrar la vacuna a una persona que haya sufrido una reacción grave tras una dosis anterior.', 3, 5, 10, 99)

-- Creo Centros medicos
EXEC s_CrearCentroMedico 'Sanatorio Anchorena', '112536252', 'sanchorena@gmail.com', 'Anchorena',2342,'','CABA','CABA','Argentina'
EXEC s_CrearCentroMedico 'Sanatorio Mitre', '112536252', 'sanchorena@gmail.com', 'Mitre',2342,'','CABA','CABA','Argentina'
EXEC s_CrearCentroMedico 'Sanatorio Trinidad', '112536252', 'sanchorena@gmail.com', 'Santa Fe',2342,'','CABA','CABA','Argentina'

-- Creo dosis de vacunas
EXEC s_CrearVacunaDosis 'NH1231', 1, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'NH2123', 1, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'NH2124', 1, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'NH2125', 1, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1231', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1232', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1233', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1234', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1235', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'RP1236', 2, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'LE3231', 3, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'LE3232', 3, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'LE3233', 3, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'LE3234', 3, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'BR0021', 4, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'BR0022', 4, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'BR0023', 4, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'BR0024', 4, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'CE10024', 5, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'CE10025', 5, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'CE10026', 5, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'CE10027', 5, '2021-01-01', '2021-02-02', 1
EXEC s_CrearVacunaDosis 'CE10028', 5, '2021-01-01', '2021-02-02', 1

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
INSERT INTO Usuario(Usuario, Password, UltimoLogin, Activo)
VALUES
('Admin', 'CC-03-E7-47-A6-AF-BB-CB-F8-BE-76-68-AC-FE-BE-E5', GETDATE(), 1);
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

