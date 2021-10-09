CREATE PROCEDURE [dbo].[s_AgregarCoberturaMedica]
	@coberturaNombre		VARCHAR(120)
AS
BEGIN
	INSERT INTO [dbo].[CoberturaMedica] (Nombre)
	VALUES
	(@coberturaNombre)
END
