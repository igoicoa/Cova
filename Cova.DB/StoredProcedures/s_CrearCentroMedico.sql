CREATE PROCEDURE [dbo].[s_CrearCentroMedico]
	@Nombre								VARCHAR(120),
	@Telefono							VARCHAR(20),
	@Email								VARCHAR(120),
	@Calle								VARCHAR(120),
	@Numero								INT,
	@Piso								VARCHAR(20),
	@Localidad							VARCHAR(120),
	@Provincia							VARCHAR(120),
	@Pais								VARCHAR(120)

AS
BEGIN
	DECLARE @IdDomicilio	BIGINT

	INSERT INTO [dbo].[Domicilio] (Calle, Numero, Piso, Localidad, Provincia, Pais)
	VALUES
	(@Calle, @Numero, @Piso, @Localidad, @Provincia, @Pais)
	SET @IdDomicilio = SCOPE_IDENTITY();

	INSERT INTO [dbo].[CentroMedico] (Nombre, Telefono, Email, DomicilioId)
	VALUES
	(@Nombre, @Telefono, @Email, @IdDomicilio)

END