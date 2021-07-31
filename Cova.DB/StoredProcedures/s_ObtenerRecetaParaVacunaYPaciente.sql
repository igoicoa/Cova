CREATE PROCEDURE [dbo].[s_ObtenerRecetaParaVacunaYPaciente]
	@PacienteId		BIGINT,
	@VacunaId		INT
AS
BEGIN
	SELECT r.RecetaId
			,r.FechaPrescripcion
			,r.VacunaId
			,p.ProfesionalId
			,p.Apellido AS MedicoApellido
			,p.Nombre AS MedicoNombre
	FROM [dbo].[Receta] r
	INNER JOIN [dbo].[Profesional] p ON p.ProfesionalId = r.ProfesionalId
	WHERE PacienteId = @PacienteId AND VacunaId = @VacunaId
END
