CREATE PROCEDURE [dbo].[s_AgregarPermisosAdministrador]
	@IdUsuario		BIGINT

AS
BEGIN
	DECLARE @permiso INT = 0;
	WHILE @permiso < 50
	BEGIN
		INSERT INTO [dbo].[UsuarioPermiso] (UsuarioID, TipoPermiso)
		VALUES
		(@IdUsuario, @permiso)
		SET @permiso = @permiso + 1;
	END
END
