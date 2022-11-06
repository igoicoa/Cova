CREATE PROCEDURE [dbo].[s_BuscarEnfermero]
	@Usuario	VARCHAR(30),
	@DNI		VARCHAR(30)
AS
BEGIN
	SELECT p.Nombre
		,u.UsuarioID
		,u.Usuario
		,p.ProfesionalId
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
		,u.Activo
	FROM Profesional p
	INNER JOIN Enfermero e ON e.ProfesionalId = p.ProfesionalId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = p.UsuarioID
	WHERE u.Usuario LIKE '%' + @Usuario + '%' AND CONVERT(VARCHAR(30), p.DNI) LIKE '%' + @DNI + '%'
END

