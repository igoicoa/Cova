CREATE PROCEDURE [dbo].[s_ObtenerControlCambios]

AS
BEGIN
	SELECT cp.ControlCambioId
	   ,cp.PacienteId
	   ,cp.UsuarioId
	   ,cp.Nombre
	   ,cp.Apellido
	   ,cp.DNI
	   ,cp.FechaNacimiento
	   ,cp.Sexo
	   ,cp.EstadoCivil
	   ,cp.Telefono
	   ,cp.Email
	   ,cp.Calle
	   ,cp.Numero
	   ,cp.Piso
	   ,cp.Localidad
	   ,cp.Provincia
	   ,cp.Pais
	   ,cm.Nombre AS CoberturaMedica
	   ,cmp.Nombre AS [Plan]
	   ,cp.NumeroAfiliado
	   ,cp.FechaVencimiento
	   ,u.UsuarioID AS UsuarioModificadorId
	   ,u.Usuario AS UsuarioModificador
	   ,cp.FechaModificacion
	   ,cp.TipoCambio
	FROM [dbo].[ControlCambio_Paciente] cp
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = cp.UsuarioModificadorId
	LEFT JOIN [dbo].[CoberturaMedica] cm ON cm.CoberturaMedicaId = cp.CoberturaMedicaId
	LEFT JOIN [dbo].[CoberturaMedicaPlan] cmp ON cp.CoberturaMedicaPlanId = cmp.PlanId
END
