CREATE PROCEDURE [dbo].[s_ObtenerVacunasAplicadasEsquemaIncompleto]
	@PacienteId		BIGINT
AS
BEGIN
	CREATE TABLE #VacunasCompletas
	(VacunaId	INT,
	CantidadDosisAplicadas	INT
	)

	INSERT INTO #VacunasCompletas (VacunaId, CantidadDosisAplicadas)
	SELECT VacunaId, COUNT(VacunaId)
	FROM [dbo].[VacunaDosis] vd
	WHERE vd.PacienteId = @PacienteId
	GROUP BY VacunaId

	SELECT v.VacunaId
	   ,v.Nombre AS VacunaNombre
	   ,l.LaboratorioId
	   ,l.Nombre AS LaboratorioNombre
	   ,v.CantidadDosis
	   ,v.Descripcion
	   ,v.Contraindicaciones
	   ,vd.Lote
	   ,vd.Dosis
	   ,vd.FechaAplicacion
	   ,vd.FechaElaboracion
	   ,vd.FechaVencimiento
	   ,vd.ObservacionPaciente
	   ,vd.IndicacionMedico
	FROM [dbo].[VacunaDosis] vd
	INNER JOIN [dbo].[Vacuna] v ON vd.VacunaId = v.VacunaId
	INNER JOIN [dbo].[Laboratorio] l ON l.LaboratorioId = v.LaboratorioId
	INNER JOIN #VacunasCompletas vc ON vc.VacunaId = vd.VacunaId
	WHERE vd.PacienteId = @PacienteId AND vc.CantidadDosisAplicadas < v.CantidadDosis
END