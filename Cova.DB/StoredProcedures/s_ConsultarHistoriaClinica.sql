CREATE PROCEDURE [dbo].[s_ConsultarHistoriaClinica]
	@PacienteId		BIGINT
AS
BEGIN
	SELECT  h.HistoriaClinicaId
		   ,h.PacienteId
		   ,p.ProfesionalId
		   ,p.Apellido
		   ,p.Nombre
		   ,h.Fecha
		   ,h.Observacion
	FROM [dbo].[HistoriaClinica] h
	INNER JOIN [dbo].[Profesional] p ON h.ProfesionalId = p.ProfesionalId
	WHERE h.PacienteId = @PacienteId
END
