CREATE PROCEDURE [dbo].[s_ActualizarAdministrador]
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
	@Activo								BIT,
	@Password							VARCHAR(50) = NULL
	
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @DomicilioId			BIGINT,
				@AdministradorId		BIGINT

		SET @AdministradorId = (SELECT AdministradorId 
							    FROM [dbo].[Administrador] a
							    INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = a.UsuarioID
							    WHERE u.UsuarioID = @UsuarioId
							    )

		SET @DomicilioId = (SELECT DomicilioId 
							FROM [dbo].[Administrador] a
							WHERE a.AdministradorId = @AdministradorId
							)

		UPDATE [dbo].[Administrador] SET
			Apellido = @Apellido,
			Nombre = @Nombre,
			DNI = @DNI,
			FechaNacimiento = @FechaNacimiento,
			Sexo = @Sexo,
			EstadoCivil = @EstadoCivil,
			Telefono = @Telefono,
			Email = @Email
		WHERE AdministradorId = @AdministradorId

		UPDATE [dbo].[Domicilio] SET
			Calle = @Calle,
			Numero = @Numero,
			Piso = @Piso,
			Localidad = @Localidad,
			Provincia = @Provincia,
			Pais = @Pais
		WHERE DomicilioId = @DomicilioId

		UPDATE [dbo].[Usuario] SET
				Activo = @Activo
		WHERE UsuarioID = @UsuarioId

		IF (@Password IS NOT NULL AND @Password <> '')
		BEGIN
			UPDATE [dbo].[Usuario] SET
				[Password] = @Password
			WHERE UsuarioID = @UsuarioId
		END

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
	END CATCH
END