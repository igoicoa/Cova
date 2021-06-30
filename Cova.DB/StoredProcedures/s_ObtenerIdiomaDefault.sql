CREATE PROCEDURE [dbo].[s_ObtenerIdiomaDefault]

AS
BEGIN
	SELECT Nombre FROM [dbo].[Idioma] i WHERE i.[Default] = 1
END
