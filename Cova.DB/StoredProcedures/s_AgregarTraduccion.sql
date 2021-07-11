CREATE PROCEDURE [dbo].[s_AgregarTraduccion]
	@NombreIdioma		VARCHAR(50),
	@NombreEtiqueta		VARCHAR(150),
	@PalabraTraducida	VARCHAR(250)
AS
BEGIN
	DECLARE @IdiomaId	INT,
			@EtiquetaId	INT

	SET @IdiomaId = (SELECT TOP 1 IdiomaId FROM [dbo].[Idioma] WHERE Nombre = @NombreIdioma)
	SET @EtiquetaId = (SELECT TOP 1 EtiquetaId FROM [dbo].[Etiqueta] WHERE Nombre = @NombreEtiqueta)

	INSERT INTO Traduccion (Traduccion, IdiomaId, EtiquetaId)
	VALUES (@PalabraTraducida, @IdiomaId, @EtiquetaId)

END

