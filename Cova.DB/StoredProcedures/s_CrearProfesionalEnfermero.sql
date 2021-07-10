CREATE PROCEDURE [dbo].[s_CrearProfesionalEnfermero]
	@Apellido				VARCHAR(120),
	@Nombre					VARCHAR(120),
	@DNI					INT,
	@FechaNacimiento		VARCHAR(120),
	@Sexo					VARCHAR(2),
	@EstadoCivil			VARCHAR(15),
	@Telefono				VARCHAR(20),
	@Email					VARCHAR(120),
	@MatriculaEnfermero		INT,
	@Password				VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario		BIGINT
	DECLARE @IdProfesional	BIGINT

	INSERT INTO Usuario (Usuario, Password)
	VALUES
	(LEFT(@Nombre, 1) + @apellido, @Password)
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO Profesional (Apellido, Nombre, DNI, FechaNacimiento, Sexo, EstadoCivil, Telefono, Email, UsuarioID)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Sexo, @EstadoCivil, @Telefono,   @Email, @IdUsuario)
	SET @IdProfesional = SCOPE_IDENTITY();

	INSERT INTO Enfermero (ProfesionalId, MatriculaEnfermero)
	VALUES
	(@IdProfesional, @MatriculaEnfermero)

END