-- ================================================================
-- Author:		Cova
-- Create date: 15/05/2021
-- Description:	Obtiene un usuario a partir de su nombre de usuario
-- ================================================================
CREATE PROCEDURE s_ObtenerUsuario 
	@NombreUsuario varchar(30)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @TipoUsuario	VARCHAR(30)

	IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Paciente] p ON p.UsuarioID = u.UsuarioID WHERE u.Usuario = @NombreUsuario)
	BEGIN
		SET @TipoUsuario = 'Paciente';
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Profesional] p ON p.UsuarioID = u.UsuarioID INNER JOIN [dbo].[Medico] m ON m.ProfesionalId = p.ProfesionalId WHERE u.Usuario = @NombreUsuario)
	BEGIN 
		SET @TipoUsuario = 'Medico';
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Profesional] p ON p.UsuarioID = u.UsuarioID INNER JOIN [dbo].[Enfermero] e ON e.ProfesionalId = p.ProfesionalId WHERE u.Usuario = @NombreUsuario)
	BEGIN 
		SET @TipoUsuario = 'Enfermero';
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Administrador] a ON a.UsuarioID = u.UsuarioID WHERE u.Usuario = @NombreUsuario)
	BEGIN 
		SET @TipoUsuario = 'Administrador';
	END

    SELECT u.UsuarioID, u.Usuario, u.Password, u.UltimoLogin, u.Activo, @TipoUsuario AS TipoUsuario
	FROM Usuario u
	WHERE u.Usuario = @NombreUsuario
END
GO
