CREATE PROCEDURE [dbo].[s_ObtenerVacunaCentroMedicoAAplicar]
	@CentroMedicoId		INT,
	@VacunaNombre		VARCHAR(150),
	@LaboratorioNombre	VARCHAR(150),
	@Lote				VARCHAR(100)
AS
BEGIN
	SELECT vd.Lote
	   ,vd.FechaElaboracion
	   ,vd.FechaVencimiento
	   ,v.VacunaId AS VacunaId
	   ,v.Nombre AS NombreVacuna
	   ,v.Descripcion
	   ,v.Prospecto
	   ,v.Contraindicaciones
	   ,v.CantidadDosis
	   ,v.EdadMinimaAplicacion
	   ,v.EdadMaximaAplicacion
	   ,l.LaboratorioId
	   ,l.Nombre AS NombreLaboratorio
	FROM [dbo].[VacunaDosis] vd
	INNER JOIN [dbo].[Vacuna] v ON v.VacunaId = vd.VacunaId
	INNER JOIN [dbo].[CentroMedico] cm ON vd.CentroMedicoId = cm.CentroMedicoId
	INNER JOIN [dbo].[Laboratorio] l ON l.LaboratorioId = v.LaboratorioId
	WHERE cm.CentroMedicoId = @CentroMedicoId AND v.Nombre LIKE '%' + @VacunaNombre + '%' AND l.Nombre LIKE '%' + @LaboratorioNombre + '%'
	AND vd.PacienteId IS NULL and vd.FechaAplicacion IS NULL
END
