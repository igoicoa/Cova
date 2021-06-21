CREATE PROCEDURE s_ObtenerPermisosUsuario
	@IDUsuario int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT TipoPermiso FROM [dbo].[UsuarioPermiso]
	WHERE UsuarioID = @IDUsuario

END
GO
