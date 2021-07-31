CREATE PROCEDURE [dbo].[s_ObtenerVacunas]

AS
BEGIN
	SELECT VacunaId
			,v.Nombre AS NombreVacuna
			,Descripcion
			,Prospecto
			,Contraindicaciones
			,CantidadDosis
			,EdadMinimaAplicacion
			,EdadMaximaAplicacion
			,l.LaboratorioId
			,l.Nombre AS NombreLaboratorio
	FROM [dbo].[Vacuna] v
	INNER JOIN [dbo].[Laboratorio] l ON l.LaboratorioId = v.LaboratorioId
END
