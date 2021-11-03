CREATE PROCEDURE [dbo].[s_ActualizarPaciente]
	@UsuarioId							BIGINT,
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
	@Activo								BIT,
	@Password							VARCHAR(50) = NULL,
	@UsuarioModificadorId				BIGINT

AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @DomicilioId			BIGINT,
				@CoberturaPacienteId	BIGINT,
				@PacienteId				BIGINT,
				@TipoCambio				VARCHAR(100)

		SET @PacienteId = (SELECT PacienteId 
						   FROM [dbo].[Paciente] p
						   INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
						   WHERE u.UsuarioID = @UsuarioId
						   )

		SET @DomicilioId = (SELECT DomicilioId 
							FROM [dbo].[Paciente] p
							WHERE p.PacienteId = @PacienteId
							)

		SET @CoberturaPacienteId = (SELECT p.CoberturaMedicaPacienteId
									FROM [dbo].[Paciente] p
									WHERE p.PacienteId = @PacienteId
									)

		UPDATE [dbo].[Paciente] SET
			Apellido = @Apellido,
			Nombre = @Nombre,
			DNI = @DNI,
			FechaNacimiento = @FechaNacimiento,
			Sexo = @Sexo,
			EstadoCivil = @EstadoCivil,
			Telefono = @Telefono,
			Email = @Email
		WHERE PacienteId = @PacienteId

		UPDATE [dbo].[Domicilio] SET
			Calle = @Calle,
			Numero = @Numero,
			Piso = @Piso,
			Localidad = @Localidad,
			Provincia = @Provincia,
			Pais = @Pais
		WHERE DomicilioId = @DomicilioId

		IF (@CoberturaPacienteId IS NOT NULL AND @CoberturaMedicaId IS NOT NULL AND @CoberturaMedicaPlanId IS NOT NULL AND @CoberturaMedicaNumeroAfiliado IS NOT NULL)
		BEGIN
			UPDATE [dbo].[CoberturaMedicaPaciente] SET
				CoberturaMedicaId = @CoberturaMedicaId,
				CoberturaMedicaPlanId = @CoberturaMedicaPlanId,
				NumeroAfiliado = @CoberturaMedicaNumeroAfiliado,
				FechaVencimiento = @CoberturaMedicaFechaVencimiento
			WHERE CoberturaMedicaPacienteId = @CoberturaPacienteId
		END
		ELSE IF (@CoberturaPacienteId IS NULL AND @CoberturaMedicaId IS NOT NULL AND @CoberturaMedicaPlanId IS NOT NULL AND @CoberturaMedicaNumeroAfiliado IS NOT NULL)
		BEGIN
			DECLARE @CoberturaMedicaPacienteId BIGINT;
			INSERT INTO [dbo].[CoberturaMedicaPaciente] (CoberturaMedicaId, CoberturaMedicaPlanId, NumeroAfiliado, FechaVencimiento)
			VALUES
			(@CoberturaMedicaId, @CoberturaMedicaPlanId, @CoberturaMedicaNumeroAfiliado, @CoberturaMedicaFechaVencimiento)
			SET @CoberturaMedicaPacienteId = SCOPE_IDENTITY();

			UPDATE [dbo].[Paciente] SET CoberturaMedicaPacienteId = @CoberturaMedicaPacienteId WHERE PacienteId = @PacienteId
		END
		ELSE IF (@CoberturaPacienteId IS NOT NULL AND @CoberturaMedicaId IS NULL)
		BEGIN
			DELETE FROM [dbo].[CoberturaMedicaPaciente] WHERE CoberturaMedicaPacienteId = @CoberturaMedicaPacienteId

			UPDATE [dbo].[Paciente] SET CoberturaMedicaPacienteId = NULL WHERE PacienteId = @PacienteId
		END

		UPDATE [dbo].[Usuario] SET
				Activo = @Activo
		WHERE UsuarioID = @UsuarioId

		IF (@Password IS NOT NULL AND @Password <> '')
		BEGIN
			UPDATE [dbo].[Usuario] SET
				[Password] = @Password
			WHERE UsuarioID = @UsuarioId
		END

		IF(@Activo = 1)
		BEGIN
			SET @TipoCambio = 'MODIFICACION'
		END
		ELSE
		BEGIN
			SET @TipoCambio = 'INACTIVO'
		END

		INSERT INTO [ControlCambio_Paciente] (Apellido, PacienteId, UsuarioId, Activo, Nombre, DNI, FechaNacimiento, Sexo, EstadoCivil, Telefono, Email, Calle, Numero, Piso, Localidad, Provincia, Pais, CoberturaMedicaId, CoberturaMedicaPlanId, NumeroAfiliado, FechaVencimiento, UsuarioModificadorId, FechaModificacion, TipoCambio)
		VALUES
		(@Apellido, @PacienteId, @UsuarioId, @Activo, @Nombre, @DNI, @FechaNacimiento, @Sexo, @EstadoCivil, @Telefono, @Email, @Calle, @Numero, @Piso, @Localidad, @Provincia, @Pais, @CoberturaMedicaId, @CoberturaMedicaPlanId, @CoberturaMedicaNumeroAfiliado, @CoberturaMedicaFechaVencimiento, @UsuarioModificadorId, GETDATE(), @TipoCambio)

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
	END CATCH
END