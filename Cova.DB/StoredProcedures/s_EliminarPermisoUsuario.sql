CREATE PROCEDURE [dbo].[s_EliminarPermisoUsuario]
	@UsuarioID		BIGINT,
	@TipoPermiso	INT
AS
BEGIN
	DELETE FROM [dbo].[UsuarioPermiso] WHERE UsuarioID = @UsuarioID AND TipoPermiso = @TipoPermiso
END
