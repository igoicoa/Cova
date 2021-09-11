CREATE PROCEDURE [dbo].[s_ObtenerDVV]
	@Entidad		VARCHAR(200)
AS
BEGIN
	SELECT DVV
	FROM [dbo].[DigitoVerificador]
	WHERE Entidad = @Entidad
END
