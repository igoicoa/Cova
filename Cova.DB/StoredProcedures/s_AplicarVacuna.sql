CREATE PROCEDURE [dbo].[s_AplicarVacuna]
	@PacienteId			BIGINT,
	@FechaAplicacion	DATETIME,
	@Dosis				INT,
	@Lote				VARCHAR(100),
	@VacunaId			INT,
	@DVH				INT
AS
BEGIN
	UPDATE [dbo].[VacunaDosis] SET PacienteId = @PacienteId
									,FechaAplicacion = @FechaAplicacion
									,Dosis = @Dosis
									,DVH = @DVH
	WHERE Lote = @Lote AND VacunaId = @VacunaId
END
