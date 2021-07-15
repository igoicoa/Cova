CREATE PROCEDURE [dbo].[s_ObtenerCoberturasMedicasPlanes]
	@CoberturaMedicaId	INT
AS
BEGIN
	SELECT PlanId, Nombre 
	FROM CoberturaMedicaPlan
	WHERE CoberturaMedicaId = @CoberturaMedicaId
END
