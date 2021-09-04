CREATE PROCEDURE [dbo].[s_ObtenerAntecedentesPersonalesPaciente]
	@PacienteId		BIGINT
AS
BEGIN
	SELECT a.AntecedentesPersonalesId
	FROM [dbo].[AntecedentesPersonales_Paciente] a
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = a.PacienteId
	WHERE p.PacienteId = @PacienteId
END
