CREATE PROCEDURE [dbo].[s_CrearCertificado]
	@FechaPrescripcion		DATETIME,
	@PacienteId				BIGINT,
	@ProfesionalId			BIGINT,
	@Observacion			VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Certificado] (FechaPrescripcion, PacienteId, ProfesionalId, Observacion)
	VALUES
	(@FechaPrescripcion, @PacienteId, @ProfesionalId, @Observacion)
END
