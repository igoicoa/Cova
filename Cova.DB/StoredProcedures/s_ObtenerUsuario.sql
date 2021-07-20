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

    SELECT u.UsuarioID, u.Usuario, u.Password, u.UltimoLogin, u.Activo
	FROM Usuario u
	WHERE u.Usuario = @NombreUsuario
END
GO
