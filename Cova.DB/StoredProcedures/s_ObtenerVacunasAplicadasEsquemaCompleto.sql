CREATE PROCEDURE [dbo].[s_ObtenerVacunasAplicadasEsquemaCompleto]
	@PacienteId		BIGINT
AS
BEGIN
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
	WHERE vd.PacienteId = @PacienteId AND vd.FechaAplicacion IS NOT NULL
END
