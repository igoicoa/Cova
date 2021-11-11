CREATE PROCEDURE [dbo].[s_ObtenerTurnosDisponibles]
	@ProfesionalId		BIGINT
AS
BEGIN
	SELECT  td.TurnoDisponibleId
		   ,td.DiaSemana
		   ,td.HoraDesde
		   ,td.HoraHasta
	FROM [dbo].[TurnoDisponible] td
	WHERE ProfesionalId = @ProfesionalId
END
