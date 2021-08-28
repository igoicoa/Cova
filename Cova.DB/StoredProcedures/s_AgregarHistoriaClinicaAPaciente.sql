CREATE PROCEDURE [dbo].[s_AgregarHistoriaClinicaAPaciente]
	@PacienteId			BIGINT,
	@ProfesionalId		BIGINT,
	@PFecha				DATETIME,
	@Observacion		VARCHAR(MAX),
	@Peso				DECIMAL(18,2)
AS
BEGIN
	INSERT INTO [dbo].[HistoriaClinica] (PacienteId, ProfesionalId, Fecha, Observacion, Peso)
	VALUES
	(@PacienteId, @ProfesionalId, @PFecha, @Observacion, @Peso)
END
