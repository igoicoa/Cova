CREATE PROCEDURE [dbo].[s_ObtenerIdiomas]

AS
BEGIN
	SELECT Nombre, [Default]
	FROM [dbo].[Idioma]
END
