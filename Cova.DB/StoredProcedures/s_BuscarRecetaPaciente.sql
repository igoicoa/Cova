CREATE PROCEDURE [dbo].[s_BuscarRecetaPaciente]
	@PacienteId		BIGINT
	
AS
BEGIN
	SELECT r.RecetaId
	   ,pr.ProfesionalId
	   ,pr.Apellido AS MedicoApellido
	   ,pr.Nombre AS MedicoNombre
	   ,m.MatriculaNacional AS MatriculaNacional
	   ,m.MatriculaProvincial AS MatriculaProvincial
	   ,r.FechaPrescripcion
	   ,r.Observacion
	   ,r.VacunaId
	   ,v.Nombre AS VacunaNombre
	FROM [dbo].[Receta] r
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = r.PacienteId
	INNER JOIN [dbo].[Profesional] pr ON pr.ProfesionalId = r.ProfesionalId
	INNER JOIN [dbo].[Medico] m ON m.ProfesionalId = pr.ProfesionalId
	LEFT JOIN [dbo].[Vacuna] v ON v.VacunaId = r.VacunaId
	WHERE (p.PacienteId = @PacienteId OR @PacienteId = 0)

END
