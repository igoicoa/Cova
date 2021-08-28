CREATE PROCEDURE [dbo].[s_BitacoraRegistrar]
	@Fecha			DATETime,
	@Criticidad		VARCHAR(120),
	@Mensaje		VARCHAR(MAX),
	@Funcionalidad	VARCHAR(200),
	@UsuarioId		BIGINT = NULL
AS
BEGIN
	INSERT INTO [dbo].[Bitacora] (Fecha, Criticidad, Mensaje, Funcionalidad, UsuarioId)
	VALUES
	(@Fecha, @Criticidad, @Mensaje, @Funcionalidad, @UsuarioId)
END
