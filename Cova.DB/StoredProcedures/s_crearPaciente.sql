﻿CREATE PROCEDURE [dbo].[s_CrearPaciente]
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
	@CoberturaMedicaId					INT = NULL,
	@CoberturaMedicaPlanId				INT = NULL,
	@CoberturaMedicaNumeroAfiliado		VARCHAR(100) = NULL,
	@CoberturaMedicaFechaVencimiento	DATETIME = NULL,
	@Password							VARCHAR(250)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IdUsuario					BIGINT,
			@IdCoberturaMedicaPaciente	BIGINT = NULL,
			@IdDomicilio				BIGINT,
			@IdPaciente					BIGINT,
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

	IF(@CoberturaMedicaId IS NOT NULL)
	BEGIN
		INSERT INTO [dbo].[CoberturaMedicaPaciente] (CoberturaMedicaId, CoberturaMedicaPlanId, NumeroAfiliado, FechaVencimiento)
		VALUES
		(@CoberturaMedicaId, @CoberturaMedicaPlanId, @CoberturaMedicaNumeroAfiliado, @CoberturaMedicaFechaVencimiento)
		SET @IdCoberturaMedicaPaciente = SCOPE_IDENTITY();
	END

	INSERT INTO [dbo].[Paciente] (Apellido, Nombre, DNI, FechaNacimiento, Sexo, EstadoCivil, Telefono, Email, CoberturaMedicaPacienteId, UsuarioID, DomicilioId)
	VALUES
	(@Apellido, @Nombre, @DNI, @FechaNacimiento, @Sexo, @EstadoCivil, @Telefono,  @Email, @IdCoberturaMedicaPaciente, @IdUsuario, @IdDomicilio)
	SET @IdPaciente = SCOPE_IDENTITY();
	
	EXEC [dbo].[s_AgregarPermisosPaciente] @IDUsuario
END