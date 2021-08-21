CREATE PROCEDURE [dbo].[s_BitacoraObtenerRegistros]
	@FechaDesde		DATETIME,
	@FechaHasta		DATETIME,
	@UsuarioId		BIGINT,
	@Criticidad		VARCHAR(120)

AS
BEGIN
	SELECT b.BitacoraId
		  ,b.Fecha
		  ,b.Criticidad
		  ,u.Usuario
		  ,b.Mensaje
		  ,b.Funcionalidad
	FROM [dbo].[Bitacora] b
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioId = b.UsuarioId
	WHERE b.Fecha BETWEEN @FechaDesde AND @FechaHasta AND b.UsuarioId = @UsuarioId AND b.Criticidad = @Criticidad
	ORDER BY Fecha DESC
END
