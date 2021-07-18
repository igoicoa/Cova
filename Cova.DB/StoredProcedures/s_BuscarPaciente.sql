﻿CREATE PROCEDURE [dbo].[s_BuscarPaciente]
	@Usuario	VARCHAR(30) = NULL,
	@DNI		INT  = NULL
AS
BEGIN
	SELECT p.Nombre
	,p.Apellido
	,p.DNI
	,p.FechaNacimiento
	,p.Sexo
	,p.EstadoCivil
	,p.Telefono
	,p.Email
	,d.Calle
	,d.Numero
	,ISNULL(d.Piso, '') AS Piso
	,d.Localidad
	,d.Provincia
	,d.Pais
	,ISNULL(c.Nombre,'-') AS CoberturaMedica
	,ISNULL(cp.Nombre,'-') AS [Plan]
	,ISNULL(cpa.NumeroAfiliado,'-') AS NumeroAfiliado
	,ISNULL(cpa.FechaVencimiento,'') AS FechaVencimiento
	FROM Paciente p
	LEFT JOIN CoberturaMedicaPaciente cpa ON cpa.CoberturaMedicaPacienteId = p.CoberturaMedicaPacienteId
	LEFT JOIN CoberturaMedica c ON cpa.CoberturaMedicaId = c.CoberturaMedicaId
	LEFT JOIN CoberturaMedicaPlan cp ON cpa.CoberturaMedicaPlanId = cp.PlanId
	INNER JOIN Domicilio d ON d.DomicilioId = p.DomicilioId
	INNER JOIN Usuario u ON u.UsuarioID = p.UsuarioID
	WHERE u.Usuario = @Usuario OR p.DNI = @DNI
END