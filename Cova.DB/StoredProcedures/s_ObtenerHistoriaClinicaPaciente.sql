CREATE PROCEDURE [dbo].[s_ObtenerHistoriaClinicaPaciente]
	@PacienteId		BIGINT

AS
BEGIN
	SELECT a.*, p.*
	FROM [dbo].[HistoriaClinica] a
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = a.PacienteId
	WHERE p.PacienteId = @PacienteId
END