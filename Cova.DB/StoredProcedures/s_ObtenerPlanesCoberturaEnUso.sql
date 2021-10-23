CREATE PROCEDURE [dbo].[s_ObtenerPlanesCoberturaEnUso]
	@CoberturaMedicaId		INT
AS
BEGIN
	SELECT DISTINCT p.PlanId,
					p.Nombre
	FROM [dbo].[CoberturaMedicaPaciente] cp
	INNER JOIN [dbo].[CoberturaMedicaPlan] p ON cp.CoberturaMedicaPlanId = p.PlanId
	WHERE cp.CoberturaMedicaPlanId IN (SELECT PlanId FROM [dbo].[CoberturaMedicaPlan] WHERE CoberturaMedicaId = @CoberturaMedicaId)
END
