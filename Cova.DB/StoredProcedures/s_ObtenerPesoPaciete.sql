CREATE PROCEDURE [dbo].[s_ObtenerPesoPaciete]
	@PacienteId		BIGINT
AS
BEGIN
	SELECT TOP 1 h.Peso
	FROM [dbo].[HistoriaClinica] h
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = h.PacienteId
	WHERE p.PacienteId = @PacienteId
	ORDER BY Fecha DESC
END