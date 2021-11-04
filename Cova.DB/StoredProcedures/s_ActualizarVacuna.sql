CREATE PROCEDURE [dbo].[s_ActualizarVacuna]
	@VacunaId				INT,
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
	UPDATE [dbo].[Vacuna]
	SET	 Nombre = @Nombre
		,Descripcion = @Descripcion
		,Prospecto = @Prospecto
		,Contraindicaciones = @Contraindicaciones
		,CantidadDosis = @CantidadDosis
		,LaboratorioId = @LaboratorioId
		,EdadMinimaAplicacion = @EdadMinimaAplicacion
		,EdadMaximaAplicacion = @EdadMaximaAplicacion
	WHERE VacunaId = @VacunaId
END
