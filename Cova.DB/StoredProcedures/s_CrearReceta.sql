CREATE PROCEDURE [dbo].[s_CrearReceta]
	@FechaPrescripcion		DATETIME,
	@PacienteId				BIGINT,
	@ProfesionalId			BIGINT,
	@Observacion			VARCHAR(MAX),
	@VacunaId				INT = NULL
AS
BEGIN
	INSERT INTO [dbo].[Receta] (FechaPrescripcion, PacienteId, ProfesionalId, VacunaId, Observacion)
	VALUES
	(@FechaPrescripcion, @PacienteId, @ProfesionalId, @VacunaId, @Observacion)
END
