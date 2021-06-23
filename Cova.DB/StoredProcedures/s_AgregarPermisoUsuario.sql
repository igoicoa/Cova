CREATE PROCEDURE [dbo].[s_AgregarPermisoUsuario]
	@UsuarioID		BIGINT,
	@TipoPermiso	INT
AS
BEGIN
	INSERT INTO [dbo].[UsuarioPermiso] (UsuarioID, TipoPermiso) VALUES (@UsuarioID,@TipoPermiso)
END