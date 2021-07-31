CREATE PROCEDURE [dbo].[s_ObtenerCentrosMedicos]

AS
BEGIN
	SELECT cm.CentroMedicoId
		,cm.Nombre
		,cm.Email
		,cm.Telefono
		,d.Calle
		,d.Numero
		,d.Piso
		,d.Localidad
		,d.Provincia
		,d.Pais
	FROM [dbo].[CentroMedico] cm
	INNER JOIN [dbo].[Domicilio] d ON cm.DomicilioId = d.DomicilioId
END
