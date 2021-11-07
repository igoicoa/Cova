CREATE PROCEDURE [dbo].[s_ObtenerTurnos]
	@PacienteId			BIGINT			= NULL,
	@ProfesionalId		BIGINT			= NULL,
	@Especialidad		VARCHAR(150)	= NULL,
	@FechaDesde			DATETIME,
	@FechaHasta			DATETIME
AS
BEGIN
	SELECT  t.TurnoId					AS TurnoId
		   ,t.Comentarios				AS Comentarios
		   ,t.Asistio					AS Asistio
		   ,m.ProfesionalId				AS ProfesionalId
		   ,pr.Apellido					AS ProfesionalApellido
		   ,pr.Nombre					AS ProfesionalNombre
		   ,pr.DNI						AS ProfesionalDNI
		   ,pr.FechaNacimiento			AS ProfesionalFechaNacimiento
		   ,pr.Sexo						AS ProfesionalSexo
		   ,pr.EstadoCivil				AS ProfesionalEstadoCivil
		   ,pr.Telefono					AS ProfesionalTelefono
		   ,pr.Email					AS ProfesionalEmail
		   ,m.MatriculaNacional			AS ProfesionalMatriculaNacional
		   ,m.MatriculaProvincial		AS ProfesionalMatriculaProvincial
		   ,m.Especialidad				AS ProfesionalEspecialidad
		   ,p.PacienteId				AS PacienteId
		   ,p.Nombre					AS PacienteNombre
		   ,p.Apellido					AS PacienteApellido
		   ,p.DNI						AS PacienteDNI
		   ,p.FechaNacimiento			AS PacienteFechaNacimiento
		   ,p.Sexo						AS PacienteSexo
		   ,p.EstadoCivil				AS PacienteEstadoCivil
		   ,p.Telefono					AS PacienteTelefono
		   ,p.Email						AS PacienteEmail
		   ,c.Nombre					AS PacienteCoberturaMedica
		   ,cp.Nombre					AS PacientePlan
		   ,cpa.NumeroAfiliado			AS PacienteNumeroAfiliado
		   ,cpa.FechaVencimiento		AS PacienteFechaVencimiento
		   ,cm.CentroMedicoId			AS CentroMedicoId
		   ,cm.Nombre					AS CentroMedicoNombre
		   ,cm.Telefono					AS CentroMedicoTelefono
	FROM [dbo].[Turno] t
	INNER JOIN [dbo].[Profesional] pr ON pr.ProfesionalId = t.ProfesionalId
	INNER JOIN [dbo].[Medico] m ON m.ProfesionalId = pr.ProfesionalId
	INNER JOIN [dbo].[Paciente] p ON p.PacienteId = t.PacienteId
	LEFT JOIN CoberturaMedicaPaciente cpa ON cpa.CoberturaMedicaPacienteId = p.CoberturaMedicaPacienteId
	LEFT JOIN CoberturaMedica c ON cpa.CoberturaMedicaId = c.CoberturaMedicaId
	LEFT JOIN CoberturaMedicaPlan cp ON cpa.CoberturaMedicaPlanId = cp.PlanId
	INNER JOIN [dbo].[CentroMedico] cm ON cm.CentroMedicoId = t.CentroMedicoId
	WHERE t.PacienteId = @PacienteId AND t.Fecha BETWEEN @FechaDesde AND @FechaHasta

END
