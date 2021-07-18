﻿CREATE PROCEDURE [dbo].[s_BuscarMedico]
	@Usuario	VARCHAR(30) = NULL,
	@DNI		INT  = NULL
AS
BEGIN
	SELECT p.Nombre
		,p.Apellido
		,p.DNI
		,p.FechaNacimiento
		,p.Sexo
		,p.EstadoCivil
		,p.Telefono
		,p.Email
		,d.Calle
		,d.Numero
		,ISNULL(d.Piso, '') AS Piso
		,d.Localidad
		,d.Provincia
		,d.Pais
		,m.Especialidad
		,m.MatriculaNacional
		,m.MatriculaProvincial
	FROM Profesional p
	INNER JOIN Medico m ON m.ProfesionalId = p.ProfesionalId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = p.UsuarioID
	WHERE u.Usuario = @Usuario OR p.DNI = @DNI
END