CREATE PROCEDURE [dbo].[s_BusquedaMedico]
	@Apellido		VARCHAR(120),
	@Nombre			VARCHAR(120),
	@Especialidad	VARCHAR(150)
AS
BEGIN
	SELECT p.Nombre
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
		,m.Especialidad
		,m.MatriculaNacional
		,m.MatriculaProvincial
	FROM Profesional p
	INNER JOIN Medico m ON m.ProfesionalId = p.ProfesionalId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	WHERE p.Apellido LIKE '%' + @Apellido + '%' AND p.Nombre LIKE '%' + @Nombre + '%' AND m.Especialidad LIKE '%' + @Especialidad + '%'
END
