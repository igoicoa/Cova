CREATE PROCEDURE [dbo].[s_BitacoraRegistrar]
	@Fecha			DATETime,
	@UsuarioId		BIGINT,
	@Criticidad		VARCHAR(120),
	@Mensaje		VARCHAR(MAX),
	@Funcionalidad	VARCHAR(200)
AS
BEGIN
	INSERT INTO [dbo].[Bitacora] (Fecha, UsuarioId, Criticidad, Mensaje, Funcionalidad)
	VALUES
	(@Fecha, @UsuarioId, @Criticidad, @Mensaje, @Funcionalidad)
END
