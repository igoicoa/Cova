CREATE PROCEDURE [dbo].[s_AsistioTurno]
	@TurnoId		BIGINT
AS
BEGIN
	UPDATE [dbo].[Turno]
	SET Asistio = 1
	WHERE TurnoId = @TurnoId
END
