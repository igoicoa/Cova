CREATE PROCEDURE [dbo].[s_ActualizarReceta]
	@RecetaId				BIGINT,
	@FechaPrescripcion		datetime,
	@PacienteId				BIGINT,
	@ProfesionalId			BIGINT,
	@VacunaId				INT,
	@Observacion			varchar(MAX)

AS
BEGIN
	UPDATE [dbo].[Receta] SET
			FechaPrescripcion = @FechaPrescripcion,
			Observacion = @Observacion
		WHERE RecetaId = @RecetaId
END