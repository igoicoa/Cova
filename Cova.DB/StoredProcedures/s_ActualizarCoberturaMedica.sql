CREATE PROCEDURE [dbo].[s_ActualizarCoberturaMedica]
	@CoberturaMedicaId			INT,
	@CoberturaMedicaNombre		VARCHAR(120)
AS
BEGIN
	UPDATE [dbo].[CoberturaMedica] SET Nombre = @CoberturaMedicaNombre WHERE CoberturaMedicaId = @CoberturaMedicaId
END
