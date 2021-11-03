CREATE PROCEDURE [dbo].[s_BuscarAdministrador]
	@Usuario	VARCHAR(30),
	@DNI		VARCHAR(30)
AS
BEGIN
	SELECT a.Nombre
		,a.AdministradorId
		,u.UsuarioID
		,u.Usuario
		,a.Apellido
		,a.DNI
		,a.FechaNacimiento
		,a.Sexo
		,a.EstadoCivil
		,a.Telefono
		,a.Email
		,d.Calle
		,d.Numero
		,ISNULL(d.Piso, '') AS Piso
		,d.Localidad
		,d.Provincia
		,d.Pais
		,u.Activo
	FROM Administrador a
	INNER JOIN Domicilio d ON d.DomicilioId = a.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = a.UsuarioID
	WHERE u.Usuario LIKE '%' + @Usuario + '%' AND CONVERT(VARCHAR(30), a.DNI) LIKE '%' + @DNI + '%'
END
