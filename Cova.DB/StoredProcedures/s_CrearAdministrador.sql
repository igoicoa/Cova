CREATE PROCEDURE [dbo].[s_CrearAdministrador]
	@Apellido							VARCHAR(120),
	@Nombre								VARCHAR(120),
	@DNI								INT,
	@FechaNacimiento					VARCHAR(120),
	@Sexo								VARCHAR(2),
	@EstadoCivil						VARCHAR(15),
	@Telefono							VARCHAR(20),
	@Email								VARCHAR(120),
	@Calle								VARCHAR(120),
	@Numero								INT,
	@Piso								VARCHAR(20),
	@Localidad							VARCHAR(120),
	@Provincia							VARCHAR(120),
	@Pais								VARCHAR(120),
	@Password							VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario					BIGINT,
			@IdDomicilio				BIGINT,
			@NombreUsuario				VARCHAR(30),
			@ContadorNombre				INT = 0

	SET @NombreUsuario = LEFT(@Nombre, 1) + @apellido
	WHILE EXISTS(SELECT UsuarioId FROM [dbo].[Usuario] WHERE Usuario = @NombreUsuario)
	BEGIN
		SET @ContadorNombre = @ContadorNombre + 1
		SET @NombreUsuario = LEFT(@Nombre, 1) + @apellido + CONVERT(VARCHAR(10), @ContadorNombre)
	END

	INSERT INTO [dbo].[Usuario] (Usuario, Password, Activo)
	VALUES
	(@NombreUsuario, @Password, 1)
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO [dbo].[Domicilio] (Calle, Numero, Piso, Localidad, Provincia, Pais)
	VALUES
	(@Calle, @Numero, @Piso, @Localidad, @Provincia, @Pais)
	SET @IdDomicilio = SCOPE_IDENTITY();

	INSERT INTO [dbo].[Administrador] (Apellido, Nombre, DNI, FechaNacimiento, Sexo, EstadoCivil, Telefono, Email, UsuarioID, DomicilioId)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Sexo, @EstadoCivil, @Telefono,  @Email, @IdUsuario, @IdDomicilio)

	EXEC [dbo].[s_AgregarPermisosAdministrador] @IDUsuario
END