CREATE PROCEDURE [dbo].[s_ObtenerVacunaDosisPaciente]
	@PacienteId		BIGINT,
	@VacunaId		INT
AS
BEGIN
	SELECT vd.VacunaId
			,v.Nombre AS VacunaNombre
			,v.EdadMinimaAplicacion
			,v.EdadMaximaAplicacion
			,vd.Dosis
			,vd.FechaAplicacion
			,vd.FechaElaboracion
			,vd.FechaVencimiento
			,vd.Lote
	FROM [dbo].[VacunaDosis] vd
	INNER JOIN [dbo].[Vacuna] v ON v.VacunaId = vd.VacunaId
	WHERE vd.VacunaId = @VacunaId AND vd.PacienteId = @PacienteId
END
