-- ================================================================
-- Author:		Cova
-- Create date: 15/05/2021
-- Description:	Obtiene un usuario a partir de su nombre de usuario
-- ================================================================
CREATE PROCEDURE s_ObtenerUsuario 
	@Usuario varchar(30)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @TipoUsuario	int

	IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Paciente] p ON p.UsuarioID = u.UsuarioID WHERE u.Usuario = @Usuario)
	BEGIN
		SET @TipoUsuario = 0;
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Profesional] p ON p.UsuarioID = u.UsuarioID INNER JOIN [dbo].[Medico] m ON m.ProfesionalId = p.ProfesionalId WHERE u.Usuario = @Usuario)
	BEGIN 
		SET @TipoUsuario = 1;
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Profesional] p ON p.UsuarioID = u.UsuarioID INNER JOIN [dbo].[Enfermero] e ON e.ProfesionalId = p.ProfesionalId WHERE u.Usuario = @Usuario)
	BEGIN 
		SET @TipoUsuario = 2;
	END
	ELSE IF EXISTS (SELECT u.usuarioID FROM [dbo].[Usuario] u INNER JOIN [dbo].[Administrador] a ON a.UsuarioID = u.UsuarioID WHERE u.Usuario = @Usuario)
	BEGIN 
		SET @TipoUsuario = 3;
	END

    SELECT u.UsuarioID, u.Usuario, u.Password, u.UltimoLogin, u.Activo, @TipoUsuario AS TipoUsuario
	FROM Usuario u
	WHERE u.Usuario = @Usuario
END
GO
