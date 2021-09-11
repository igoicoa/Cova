CREATE PROCEDURE [dbo].[s_ActualizarDVV]
	@Entidad		VARCHAR(200),
	@DVV			BIGINT
AS
BEGIN
	UPDATE [dbo].[DigitoVerificador]
	SET DVV = @DVV
	WHERE Entidad = @Entidad
END
