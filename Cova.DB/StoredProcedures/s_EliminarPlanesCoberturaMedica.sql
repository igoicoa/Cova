CREATE PROCEDURE [dbo].[s_EliminarPlanesCoberturaMedica]
	@CoberturaMedicaId		INT
AS
BEGIN
	DELETE [dbo].[CoberturaMedicaPlan] WHERE CoberturaMedicaId = @CoberturaMedicaId
END
