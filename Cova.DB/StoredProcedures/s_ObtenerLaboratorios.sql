CREATE PROCEDURE [dbo].[s_ObtenerLaboratorios]

AS
BEGIN
	SELECT LaboratorioId
		   ,Nombre
		   ,Telefono
		   ,Email
		   ,Pais
	FROM [dbo].[Laboratorio]
END
