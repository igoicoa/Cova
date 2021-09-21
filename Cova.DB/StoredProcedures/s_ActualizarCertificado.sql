CREATE PROCEDURE [dbo].[s_ActualizarCertificado]
	@CertificadoId			BIGINT,
	@FechaPrescripcion		datetime,
	@PacienteId				BIGINT,
	@ProfesionalId			BIGINT,
	@Observacion			varchar(MAX)

AS
BEGIN
	UPDATE [dbo].[Receta] SET
			FechaPrescripcion = @FechaPrescripcion
			,Observacion = @Observacion
	WHERE CertificadoId = @CertificadoId
END