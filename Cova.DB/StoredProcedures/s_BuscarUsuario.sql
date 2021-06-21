CREATE PROCEDURE [dbo].[s_BuscarUsuario]
	@NombreABuscar		VARCHAR(150),
	@ApellidoABuscar	VARCHAR(150)
AS
BEGIN
	SELECT p.Apellido, p.Nombre, p.Email, u.Usuario, 'Medico' AS TipoUsuario, u.UsuarioID 
	FROM [dbo].[Profesional] p
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
	WHERE p.Apellido LIKE '%' + @ApellidoABuscar + '%' AND p.Nombre LIKE '%' + @NombreABuscar + '%'
	UNION
	SELECT p.Apellido, p.Nombre, p.Email, u.Usuario, 'Paciente' AS TipoUsuario, u.UsuarioID
	FROM [dbo].[Paciente] p
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
	WHERE p.Apellido LIKE '%' + @ApellidoABuscar + '%' AND p.Nombre LIKE '%' + @NombreABuscar + '%'
	ORDER BY Apellido, Nombre, Email
END