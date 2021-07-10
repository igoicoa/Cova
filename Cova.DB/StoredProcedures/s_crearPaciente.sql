CREATE PROCEDURE [dbo].[s_CrearPaciente]
	@Apellido							VARCHAR(120),
	@Nombre								VARCHAR(120),
	@DNI								INT,
	@FechaNacimiento					VARCHAR(120),
	@Sexo								VARCHAR(2),
	@EstadoCivil						VARCHAR(15),
	@Telefono							VARCHAR(20),
	@Email								VARCHAR(120),
	@CoberturaMedicaId					INT,
	@CoberturaMedicaPlanId				INT,
	@CoberturaMedicaNumeroAfiliado		VARCHAR(100),
	@CoberturaMedicaFechaVencimiento	DATETIME,
	@Password							VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario		BIGINT,
			@IdCoberturaMedicaPaciente INT

	INSERT INTO Usuario (Usuario, Password)
	VALUES
	(LEFT(@Nombre, 1) + @apellido, @Password)
	SET @IdUsuario = SCOPE_IDENTITY();

	INSERT INTO CoberturaMedicaPaciente(CoberturaMedicaId, CoberturaMedicaPlanId, NumeroAfiliado, FechaVencimiento)
	VALUES
	(@CoberturaMedicaId, @CoberturaMedicaPlanId, @CoberturaMedicaNumeroAfiliado, @CoberturaMedicaFechaVencimiento)
	SET @IdCoberturaMedicaPaciente = SCOPE_IDENTITY();

	INSERT INTO Paciente (Apellido, Nombre, DNI, FechaNacimiento, Sexo, EstadoCivil, Telefono, Email, CoberturaMedicaPacienteId, UsuarioID)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Sexo, @EstadoCivil, @Telefono,  @Email, @IdCoberturaMedicaPaciente, @IdUsuario)

	EXEC [dbo].[s_AgregarPermisosPaciente] @IDUsuario
END