CREATE PROCEDURE [dbo].[s_BuscarEnfermero]
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
		,e.MatriculaEnfermero
	FROM Profesional p
	INNER JOIN Enfermero e ON e.ProfesionalId = p.ProfesionalId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = p.UsuarioID
	WHERE u.Usuario = @Usuario OR p.DNI = @DNI
END

