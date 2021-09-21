CREATE PROCEDURE [dbo].[s_BuscarCertificadoPaciente]
	@PacienteId		BIGINT
	
AS
BEGIN
	SELECT c.CertificadoId
	   ,pr.ProfesionalId
	   ,pr.Apellido AS MedicoApellido
	   ,pr.Nombre AS MedicoNombre
	   ,m.MatriculaNacional AS MatriculaNacional
	   ,m.MatriculaProvincial AS MatriculaProvincial
	   ,c.FechaPrescripcion
	   ,c.Observacion
	FROM [dbo].[Certificado] c
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = c.PacienteId
	INNER JOIN [dbo].[Profesional] pr ON pr.ProfesionalId = c.ProfesionalId
	INNER JOIN [dbo].[Medico] m ON m.ProfesionalId = pr.ProfesionalId
	WHERE p.PacienteId = @PacienteId

END