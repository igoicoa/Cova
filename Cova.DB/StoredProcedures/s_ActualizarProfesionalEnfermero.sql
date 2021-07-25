CREATE PROCEDURE [dbo].[s_ActualizarProfesionalEnfermero]
	@UsuarioId				BIGINT,
	@Apellido				VARCHAR(120),
	@Nombre					VARCHAR(120),
	@DNI					INT,
	@FechaNacimiento		VARCHAR(120),
	@Sexo					VARCHAR(2),
	@EstadoCivil			VARCHAR(15),
	@Telefono				VARCHAR(20),
	@Email					VARCHAR(120),
	@Calle					VARCHAR(120),
	@Numero					INT,
	@Piso					VARCHAR(20),
	@Localidad				VARCHAR(120),
	@Provincia				VARCHAR(120),
	@Pais					VARCHAR(120),
	@MatriculaEnfermero		INT,
	@Activo					BIT,
	@Password				VARCHAR(50) = NULL

AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @DomicilioId			BIGINT,
				@ProfesionalId			BIGINT

		SET @ProfesionalId = (SELECT p.ProfesionalId
							  FROM [dbo].[Profesional] p
							  INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = p.UsuarioID
							  WHERE u.UsuarioID = @UsuarioId
							  )

		SET @DomicilioId = (SELECT DomicilioId 
							FROM [dbo].[Profesional] p
							WHERE p.ProfesionalId = @ProfesionalId
							)

		UPDATE [dbo].[Profesional] SET
			Apellido = @Apellido,
			Nombre = @Nombre,
			DNI = @DNI,
			FechaNacimiento = @FechaNacimiento,
			Sexo = @Sexo,
			EstadoCivil = @EstadoCivil,
			Telefono = @Telefono,
			Email = @Email
		WHERE ProfesionalId = @ProfesionalId

		UPDATE [dbo].[Domicilio] SET
			Calle = @Calle,
			Numero = @Numero,
			Piso = @Piso,
			Localidad = @Localidad,
			Provincia = @Provincia,
			Pais = @Pais
		WHERE DomicilioId = @DomicilioId

		UPDATE [dbo].[Enfermero] SET
			MatriculaEnfermero = @MatriculaEnfermero
		WHERE ProfesionalId = @ProfesionalId

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
