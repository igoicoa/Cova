CREATE PROCEDURE [dbo].[s_CrearVacunaDosis]
	@Lote				VARCHAR(100),
	@VacunaId			INT,
	@FechaElaboracion	DATETIME,
	@FechaVencimiento	DATETIME,
	@CentroMedicoId		INT
AS
BEGIN
	INSERT INTO [dbo].[VacunDosis] (Lote, VacunaId, FechaElaboracion, FechaVencimiento, CentroMedicoId)
	VALUES (@Lote, @VacunaId, @FechaElaboracion, @FechaVencimiento, @CentroMedicoId)
END
