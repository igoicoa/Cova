CREATE PROCEDURE [dbo].[s_ObtenerTraducciones]
	@Idioma VARCHAR(50)
AS
BEGIN
	SELECT e.Nombre AS EtiquetaNombre, t.Traduccion AS Traduccion
	FROM [dbo].[Traduccion] t WITH(NOLOCK)
	INNER JOIN [dbo].[Idioma] i WITH(NOLOCK) ON t.IdiomaId = i.IdiomaId
	INNER JOIN [dbo].[Etiqueta] e WITH(NOLOCK) ON e.EtiquetaId = t.EtiquetaId
	WHERE i.Nombre = @Idioma
END