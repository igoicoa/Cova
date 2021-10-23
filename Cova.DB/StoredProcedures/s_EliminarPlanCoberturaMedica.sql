CREATE PROCEDURE [dbo].[s_EliminarPlanCoberturaMedica]
	@PlanId		INT
AS
BEGIN
	DELETE [dbo].[CoberturaMedicaPlan] WHERE PlanId = @PlanId
END
