CREATE PROCEDURE [dbo].[s_ObtenerEmailUsuario]
	@Usuario	VARCHAR(30),
	@Email		VARCHAR(120)
AS
BEGIN
	DECLARE @ReturnEmail	VARCHAR(120),
			@UsuarioID		BIGINT
	SET @UsuarioID = (SELECT UsuarioID FROM Usuario WHERE Usuario = @Usuario)
	SET @ReturnEmail = NULL

	IF(@ReturnEmail IS NULL)
	BEGIN
		SET @ReturnEmail = (SELECT Email FROM Paciente WHERE Email = @Email AND UsuarioID = @UsuarioID)
	END
	IF(@ReturnEmail IS NULL OR @ReturnEmail = '')
	BEGIN
		SET @ReturnEmail = (SELECT Email FROM Profesional WHERE Email = @Email AND UsuarioID = @UsuarioID)
	END
	IF(@ReturnEmail IS NULL OR @ReturnEmail = '')
	BEGIN
		SET @ReturnEmail = (SELECT Email FROM Administrador WHERE Email = @Email AND UsuarioID = @UsuarioID)
	END

	SELECT @ReturnEmail AS ReturnEmail
END
