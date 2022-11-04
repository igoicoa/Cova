CREATE TABLE [dbo].[ControlCambio_Paciente]
(
	[ControlCambioId]			BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_ControlCambio_PacienteId]	PRIMARY KEY CLUSTERED,
    [PacienteId]                BIGINT          NOT NULL,
    [UsuarioId]                 BIGINT          NULL,
    [Activo]                    BIT             NULL,
	[Nombre]		            VARCHAR(120)	NULL, 
    [Apellido]		            VARCHAR(120)	NULL, 
    [DNI]                       INT             NULL, 
    [FechaNacimiento]           DATE            NULL,
    [Sexo]                      VARCHAR(2)      NULL,
    [EstadoCivil]               VARCHAR(15)     NULL,
    [Telefono]                  VARCHAR(20)     NULL,
    [Email]                     VARCHAR(120)    NULL,
    [Calle]                     VARCHAR(120)    NULL, 
    [Numero]                    INT             NULL, 
    [Piso]                      VARCHAR(20)     NULL, 
    [Localidad]                 VARCHAR(120)    NULL, 
    [Provincia]                 VARCHAR(120)    NULL, 
    [Pais]                      VARCHAR(120)    NULL,
    [CoberturaMedicaId]         INT             NULL,
    [CoberturaMedicaPlanId]     INT             NULL,
    [NumeroAfiliado]            VARCHAR(100)    NULL, 
    [FechaVencimiento]          DATETIME        NULL, 
    [UsuarioModificadorId] BIGINT NOT NULL, 
    [FechaModificacion] DATETIME NOT NULL, 
    [TipoCambio] VARCHAR(100) NOT NULL,


)
