CREATE PROCEDURE [dbo].[s_RestaurarPaciente]
	@ControlDeCambioId		BIGINT,
	@UsuarioModificador		BIGINT
AS
BEGIN
	DECLARE @UsuarioId							BIGINT,
			@Apellido							VARCHAR(120),
			@Nombre								VARCHAR(120),
			@DNI								INT,
			@FechaNacimiento					VARCHAR(120),
			@Sexo								VARCHAR(2),
			@EstadoCivil						VARCHAR(15),
			@Telefono							VARCHAR(20),
			@Email								VARCHAR(120),
			@Calle								VARCHAR(120),
			@Numero								INT,
			@Piso								VARCHAR(20),
			@Localidad							VARCHAR(120),
			@Provincia							VARCHAR(120),
			@Pais								VARCHAR(120),
			@CoberturaMedicaId					INT = NULL,
			@CoberturaMedicaPlanId				INT = NULL,
			@CoberturaMedicaNumeroAfiliado		VARCHAR(100) = NULL,
			@CoberturaMedicaFechaVencimiento	DATETIME = NULL,
			@Activo								BIT,
			@Password							VARCHAR(50) = NULL,
			@UsuarioModificadorId				BIGINT

	SELECT  @UsuarioId							= c.UsuarioId,
			@Apellido							= c.Apellido,
			@Nombre								= c.Nombre,
			@DNI								= c.DNI,
			@FechaNacimiento					= c.FechaNacimiento,
			@Sexo								= c.Sexo,
			@EstadoCivil						= c.EstadoCivil,
			@Telefono							= c.Telefono,
			@Email								= c.Email,
			@Calle								= c.Calle,
			@Numero								= c.Numero,
			@Piso								= c.Piso,
			@Localidad							= c.Localidad,
			@Provincia							= c.Provincia,
			@Pais								= c.Pais,
			@CoberturaMedicaId					= c.CoberturaMedicaId,
			@CoberturaMedicaPlanId				= c.CoberturaMedicaPlanId,
			@CoberturaMedicaNumeroAfiliado		= c.CoberturaMedicaNumeroAfiliado,
			@CoberturaMedicaFechaVencimiento	= c.CoberturaMedicaFechaVencimiento,
			@Activo								= c.Activo,
			@UsuarioModificadorId				= @UsuarioModificador
	FROM [dbo].[ControlDeCambio_Paciete] c
	WHERE c.ControlDeCambioId = @ControlDeCambioId

	EXEC[dbo].[s_ActualizarPaciente]	 @UsuarioId
										,@Apellido	
										,@Nombre		
										,@DNI		
										,@FechaNacimiento		
										,@Sexo		
										,@EstadoCivil		
										,@Telefono		
										,@Email		
										,@Calle
										,@Numero
										,@Piso
										,@Localidad
										,@Provincia
										,@Pais
										,@CoberturaMedicaId
										,@CoberturaMedicaPlanId
										,@CoberturaMedicaNumeroAfiliado
										,@CoberturaMedicaFechaVencimiento
										,@Activo
										,@UsuarioModificadorId
END
