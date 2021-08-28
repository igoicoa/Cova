CREATE PROCEDURE [dbo].[s_CargarAntecedentesPersonales]
	@AntecedentesPersonalesId		INT,
	@PacienteId						BIGINT
AS
BEGIN
	INSERT INTO [dbo].[AntecedentesPersonales_Paciente] (AntecedentesPersonalesId, PacienteId)
	VALUES
	(@AntecedentesPersonalesId, @PacienteId)
END
