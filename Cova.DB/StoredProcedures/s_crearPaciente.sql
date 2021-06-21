CREATE PROCEDURE [dbo].[s_CrearPaciente]
	@Apellido				VARCHAR(120),
	@Nombre					VARCHAR(120),
	@DNI					INT,
	@FechaNacimiento		VARCHAR(120),
	@Email					VARCHAR(120)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario		BIGINT

	INSERT INTO Usuario (Usuario, Password)
	VALUES
	(LEFT(@Nombre, 1) + @apellido, @DNI)
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO Paciente (Apellido, Nombre, DNI, FechaNacimiento, Email, UsuarioID)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Email, @IdUsuario)

END