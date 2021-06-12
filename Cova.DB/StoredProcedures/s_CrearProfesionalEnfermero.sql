CREATE PROCEDURE [dbo].[s_CrearProfesionalEnfermero]
	@Apellido				VARCHAR(120),
	@Nombre					VARCHAR(120),
	@DNI					INT,
	@FechaNacimiento		VARCHAR(120),
	@Email					VARCHAR(120),
	@MatriculaEnfermero		INT

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario		BIGINT
	DECLARE @IdProfesional	BIGINT

	INSERT INTO Usuario (Usuario, Password)
	VALUES
	(LEFT(@Nombre, 1) + @apellido, 'test123')
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO Profesional (Apellido, Nombre, DNI, FechaNacimiento, Email, UsuarioID)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Email, @IdUsuario)
	SET @IdProfesional = SCOPE_IDENTITY();

	INSERT INTO Enfermero (ProfesionalId, MatriculaEnfermero)
	VALUES
	(@IdProfesional, @MatriculaEnfermero)

END