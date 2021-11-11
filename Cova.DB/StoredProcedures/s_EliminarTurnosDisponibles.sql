CREATE PROCEDURE [dbo].[s_EliminarTurnosDisponibles]
	@ProfesionalId		BIGINT
AS
BEGIN
	DELETE
	FROM [dbo].[TurnoDisponible]
	WHERE ProfesionalId = @ProfesionalId
END
