CREATE PROCEDURE [dbo].[s_AgregarHistoriaClinicaAPaciente]
	@PacienteId			BIGINT,
	@ProfesionalId		BIGINT,
	@PFecha				DATETIME,
	@Observacion		VARCHAR(MAX)

AS
BEGIN
	INSERT INTO [dbo].[HistoriaClinica] (PacienteId, ProfesionalId, Fecha, Observacion)
	VALUES
	(@PacienteId, @ProfesionalId, @PFecha, @Observacion)
END
