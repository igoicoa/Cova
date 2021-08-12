CREATE PROCEDURE [dbo].[s_ActualizarReceta]
	@RecetaId				BIGINT,
	@FechaPrescripcion		datetime,
	@PacienteId				BIGINT,
	@ProfesionalId			BIGINT,
	@Observacion			varchar(MAX),
	@VacunaId				INT = NULL

AS
BEGIN
	UPDATE [dbo].[Receta] SET
			FechaPrescripcion = @FechaPrescripcion
			,Observacion = @Observacion
			,VacunaId = @VacunaId
	WHERE RecetaId = @RecetaId
END