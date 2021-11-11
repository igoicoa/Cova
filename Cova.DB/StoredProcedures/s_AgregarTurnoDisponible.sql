CREATE PROCEDURE [dbo].[s_AgregarTurnoDisponible]
	@ProfesionalId		BIGINT,
	@DiaSemana			VARCHAR(20),
	@HoraDesde			DATETIME,
	@HoraHasta			DATETIME
AS
BEGIN
	INSERT INTO [dbo].[TurnoDisponible] (ProfesionalId, DiaSemana, HoraDesde, HoraHasta)
	VALUES
	(@ProfesionalId, @DiaSemana, @HoraDesde, @HoraHasta)
END
