CREATE PROCEDURE [dbo].[s_ActualizarCertificado]
	@CertificadoId			BIGINT,
	@FechaPrescripcion		datetime,
	@Observacion			varchar(MAX)

AS
BEGIN
	UPDATE [dbo].[Certificado] SET
			 FechaPrescripcion = @FechaPrescripcion
			,Observacion = @Observacion
	WHERE CertificadoId = @CertificadoId
END