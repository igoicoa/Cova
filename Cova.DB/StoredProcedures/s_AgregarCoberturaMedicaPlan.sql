CREATE PROCEDURE [dbo].[s_AgregarCoberturaMedicaPlan]
	@CoberturaNombre		VARCHAR(120),
	@CoberturaPlanNombre	VARCHAR(100)
AS
BEGIN
	DECLARE @CoberturaMedicaId INT;
	SET @CoberturaMedicaId = (SELECT @CoberturaMedicaId FROM [dbo].[CoberturaMedica] WHERE Nombre = @CoberturaNombre)
	
	IF(@CoberturaMedicaId IS NOT NULL AND @CoberturaMedicaId <> 0)
	BEGIN
		INSERT INTO [dbo].[CoberturaMedicaPlan] (CoberturaMedicaId, Nombre)
		VALUES
		(@CoberturaMedicaId, @CoberturaPlanNombre)
	END
END
