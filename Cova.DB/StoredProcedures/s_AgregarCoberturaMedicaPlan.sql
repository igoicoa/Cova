CREATE PROCEDURE [dbo].[s_AgregarCoberturaMedicaPlan]
	@CoberturaMedicaId		INT,
	@CoberturaPlanNombre	VARCHAR(100)
AS
BEGIN
	INSERT INTO [dbo].[CoberturaMedicaPlan] (CoberturaMedicaId, Nombre)
	VALUES
	(@CoberturaMedicaId, @CoberturaPlanNombre)
END
