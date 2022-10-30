CREATE PROCEDURE [dbo].[s_EliminarCoberturaMedica]
	@CoberturaMedicaId		INT
AS
BEGIN
	DELETE [dbo].[CoberturaMedicaPlan] WHERE CoberturaMedicaId = @CoberturaMedicaId
	DELETE [dbo].[CoberturaMedica] WHERE CoberturaMedicaId = @CoberturaMedicaId
END
