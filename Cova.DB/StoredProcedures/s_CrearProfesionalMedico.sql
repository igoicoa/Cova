CREATE PROCEDURE [dbo].[s_CrearProfesionalMedico]
	@Apellido				VARCHAR(120),
	@Nombre					VARCHAR(120),
	@DNI					INT,
	@FechaNacimiento		VARCHAR(120),
	@Email					VARCHAR(120),
	@MatriculaNacional		INT,
	@MatriculaProvincial	INT,
	@Especialidad			VARCHAR(150)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario		BIGINT
	DECLARE @IdProfesional	BIGINT

	INSERT INTO Usuario (Usuario, Password)
	VALUES
	(LEFT(@Nombre, 1) + @apellido, @DNI)
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO Profesional (Apellido, Nombre, DNI, FechaNacimiento, Email, UsuarioID)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Email, @IdUsuario)
	SET @IdProfesional = SCOPE_IDENTITY();

	INSERT INTO Medico (ProfesionalId, MatriculaNacional, MatriculaProvincial, Especialidad)
	VALUES
	(@IdProfesional, @MatriculaNacional, @MatriculaProvincial, @Especialidad)

	EXEC [dbo].[s_AgregarPermisosProfesionalMedico] @IdUsuario
END