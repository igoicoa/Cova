CREATE PROCEDURE [dbo].[s_AgregarIdioma]
	@NombreIdioma	VARCHAR(50)
AS
BEGIN
	DECLARE @IdiomaExiste INT;

	SET @IdiomaExiste = (SELECT COUNT(*) FROM [dbo].[Idioma] i WHERE i.Nombre = @NombreIdioma)

	IF(@IdiomaExiste > 0)
	BEGIN
		RETURN 0;
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[Idioma] (Nombre, [Default])
		VALUES (@NombreIdioma, 0)
	END
END