CREATE PROCEDURE [dbo].[s_BuscarPaciente]
	@Usuario	VARCHAR(30),
	@DNI		VARCHAR(30)
AS
BEGIN
	SELECT p.Nombre
		,p.PacienteId
		,u.UsuarioID
		,u.Usuario
		,p.Apellido
		,p.DNI
		,p.FechaNacimiento
		,p.Sexo
		,p.EstadoCivil
		,p.Telefono
		,p.Email
		,d.Calle
		,d.Numero
		,d.Piso
		,d.Localidad
		,d.Provincia
		,d.Pais
		,c.Nombre AS CoberturaMedica
		,cp.Nombre AS [Plan]
		,cpa.NumeroAfiliado AS NumeroAfiliado
		,cpa.FechaVencimiento AS FechaVencimiento
		,cpa.CoberturaMedicaId AS CoberturaMedicaId
		,cpa.CoberturaMedicaPlanId AS CoberturaMedicaPlanId
		,u.Activo
	FROM Paciente p
	LEFT JOIN CoberturaMedicaPaciente cpa ON cpa.CoberturaMedicaPacienteId = p.CoberturaMedicaPacienteId
	LEFT JOIN CoberturaMedica c ON cpa.CoberturaMedicaId = c.CoberturaMedicaId
	LEFT JOIN CoberturaMedicaPlan cp ON cpa.CoberturaMedicaPlanId = cp.PlanId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = p.UsuarioID
	WHERE u.Usuario LIKE '%' + @Usuario + '%' AND CONVERT(VARCHAR(30), p.DNI) LIKE '%' + @DNI + '%'
END
