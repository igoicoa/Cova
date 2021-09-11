CREATE PROCEDURE [dbo].[s_CrearVacunaDosis]
	@Lote				VARCHAR(100),
	@VacunaId			INT,
	@FechaElaboracion	DATETIME,
	@FechaVencimiento	DATETIME,
	@CentroMedicoId		INT,
	@DVH				INT
AS
BEGIN
	INSERT INTO [dbo].[VacunaDosis] (Lote, VacunaId, FechaElaboracion, FechaVencimiento, CentroMedicoId, DVH)
	VALUES (@Lote, @VacunaId, @FechaElaboracion, @FechaVencimiento, @CentroMedicoId, @DVH)
END
