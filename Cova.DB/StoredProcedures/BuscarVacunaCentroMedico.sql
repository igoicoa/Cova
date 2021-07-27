CREATE PROCEDURE [dbo].[BuscarVacunaCentroMedico]
	@CentroMedicoId		INT,
	@VacunaNombre		VARCHAR(150),
	@LaboratorioId		INT,
	@Lote				VARCHAR(100)
AS
BEGIN
	SELECT vd.Lote
	   ,vd.FechaElaboracion
	   ,vd.FechaVencimiento
	   ,v.Nombre AS NombreVacuna
	   ,v.Descripcion
	   ,v.Prospecto
	   ,v.Contraindicaciones
	   ,v.CantidadDosis
	   ,l.LaboratorioId
	   ,l.Nombre AS NombreLaboratorio
	FROM [dbo].[VacunDosis] vd
	INNER JOIN [dbo].[Vacuna] v ON v.VacunaId = vd.VacunaId
	INNER JOIN [dbo].[CentroMedico] cm ON vd.CentroMedicoId = cm.CentroMedicoId
	INNER JOIN [dbo].[Laboratorio] l ON l.LaboratorioId = v.LaboratorioId
	WHERE cm.CentroMedicoId = @CentroMedicoId AND v.Nombre LIKE '%' + @VacunaNombre + '%'
END
