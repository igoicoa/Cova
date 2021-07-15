CREATE PROCEDURE [dbo].[s_ObtenerCoberturasMedicas]

AS
BEGIN
	SELECT CoberturaMedicaId, Nombre 
	FROM CoberturaMedica
END