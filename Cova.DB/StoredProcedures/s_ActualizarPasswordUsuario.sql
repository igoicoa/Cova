CREATE PROCEDURE [dbo].[s_ActualizarPasswordUsuario]
	@Usuario			VARCHAR(30),
	@NuevoPassword		VARCHAR(250)
AS
BEGIN
	UPDATE [dbo].[Usuario] SET [Password] = @NuevoPassword WHERE Usuario = @Usuario
END