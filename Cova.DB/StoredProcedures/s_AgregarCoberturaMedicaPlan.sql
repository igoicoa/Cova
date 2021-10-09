CREATE PROCEDURE [dbo].[s_AgregarCoberturaMedicaPlan]
	@coberturaNombre		VARCHAR(120),
	@coberturaPlanNombre	VARCHAR(100)
AS
BEGIN
	DECLARE @CoberturaMedicaId INT;
	SET @CoberturaMedicaId = (SELECT @CoberturaMedicaId FROM [dbo].[CoberturaMedica] WHERE Nombre = @coberturaNombre)
	
	IF(@CoberturaMedicaId IS NOT NULL AND @CoberturaMedicaId <> 0)
	BEGIN
		INSERT INTO [dbo].[CoberturaMedicaPlan] (CoberturaMedicaId, Nombre)
		VALUES
		(@CoberturaMedicaId, @coberturaPlanNombre)
	END
END
