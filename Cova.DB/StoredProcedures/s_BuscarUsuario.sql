CREATE PROCEDURE [dbo].[s_BuscarUsuario]
	@NombreABuscar		VARCHAR(150),
	@ApellidoABuscar	VARCHAR(150)
AS
BEGIN
	SELECT p.Apellido, p.Nombre, p.Email, u.Usuario, 'Profesional' AS TipoUsuario, u.UsuarioID 
	FROM [dbo].[Profesional] p
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
	WHERE p.Apellido LIKE '%' + @ApellidoABuscar + '%' AND p.Nombre LIKE '%' + @NombreABuscar + '%'
	UNION
	SELECT p.Apellido, p.Nombre, p.Email, u.Usuario, 'Paciente' AS TipoUsuario, u.UsuarioID
	FROM [dbo].[Paciente] p
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
	WHERE p.Apellido LIKE '%' + @ApellidoABuscar + '%' AND p.Nombre LIKE '%' + @NombreABuscar + '%'
	UNION
	SELECT a.Apellido, a.Nombre, a.Email, u.Usuario, 'Administrador' AS TipoUsuario, u.UsuarioID
	FROM [dbo].[Administrador] a
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = a.UsuarioID
	WHERE a.Apellido LIKE '%' + @ApellidoABuscar + '%' AND a.Nombre LIKE '%' + @NombreABuscar + '%'
	ORDER BY Apellido, Nombre, Email
END