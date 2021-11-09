CREATE PROCEDURE [dbo].[s_CancelarTurno]
	@TurnoId		BIGINT
AS
BEGIN
	DELETE FROM [dbo].[Turno]
	WHERE TurnoId = @TurnoId
END
