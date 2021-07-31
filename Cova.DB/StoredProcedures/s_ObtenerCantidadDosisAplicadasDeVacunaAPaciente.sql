CREATE PROCEDURE [dbo].[s_ObtenerCantidadDosisAplicadasDeVacunaAPaciente]
	@PacienteId		BIGINT,
	@VacunaId		INT
AS
BEGIN
	SELECT COUNT(LOTE) AS CantidadDosisAplicadas
	FROM [dbo].[VacunaDosis] vd
	WHERE vd.PacienteId = @PacienteId AND vd.VacunaId = @VacunaId AND vd.FechaAplicacion IS NOT NULL
	GROUP BY vd.PacienteId, vd.VacunaId
END
