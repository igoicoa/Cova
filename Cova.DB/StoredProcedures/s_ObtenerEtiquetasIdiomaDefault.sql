CREATE PROCEDURE [dbo].[s_ObtenerEtiquetasIdiomaDefault]
AS
BEGIN
	SELECT e.Nombre AS EtiquetaNombre, t.Traduccion AS PalabraTraducida, i.Nombre AS IdiomaDefault 
	FROM [dbo].[Etiqueta] e
	INNER JOIN [dbo].[Traduccion] t ON t.EtiquetaID = e.EtiquetaID 
	INNER JOIN Idioma i ON i.IdiomaID = t.IdiomaID AND i.[Default] = 1
END
