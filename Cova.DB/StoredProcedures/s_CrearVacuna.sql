CREATE PROCEDURE [dbo].[s_CrearVacuna]
	@Nombre					VARCHAR(150),
	@Descripcion			VARCHAR(250),
	@Prospecto				VARCHAR(MAX),
	@Contraindicaciones		VARCHAR(MAX),
	@CantidadDosis			INT,
	@LaboratorioId			INT,
	@EdadMinimaAplicacion	INT,
	@EdadMaximaAplicacion	INT
AS
BEGIN
	INSERT INTO [dbo].[Vacuna] (Nombre, Descripcion, Prospecto, Contraindicaciones, CantidadDosis, LaboratorioId, EdadMinimaAplicacion, EdadMaximaAplicacion)
	VALUES
	(@Nombre, @Descripcion, @Prospecto, @Contraindicaciones, @CantidadDosis, @LaboratorioId, @EdadMinimaAplicacion, @EdadMaximaAplicacion)
END
