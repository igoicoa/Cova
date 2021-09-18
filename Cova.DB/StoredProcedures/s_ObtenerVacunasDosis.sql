CREATE PROCEDURE [dbo].[s_ObtenerVacunasDosis]
AS
BEGIN
	SELECT vd.Lote
		  ,vd.VacunaId
		  ,vd.FechaElaboracion
		  ,vd.FechaVencimiento
		  ,vd.CentroMedicoId
		  ,vd.PacienteId
		  ,vd.FechaAplicacion
		  ,vd.Dosis
		  ,vd.ObservacionPaciente
		  ,vd.IndicacionMedico
		  ,vd.DVH
	FROM [dbo].[VacunaDosis] vd
END
