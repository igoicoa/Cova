CREATE TABLE [dbo].[ControlCambio_Paciente]
(
	[ControlCambioId]			BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_ControlCambio_PacienteId]	PRIMARY KEY CLUSTERED,
	[Nombre]		            VARCHAR(120)	NOT NULL, 
    [Apellido]		            VARCHAR(120)	NOT NULL, 
    [DNI]                       INT             NOT NULL, 
    [FechaNacimiento]           DATE            NOT NULL,
    [Sexo]                      VARCHAR(2)      NOT NULL,
    [EstadoCivil]               VARCHAR(15)     NULL,
    [Telefono]                  VARCHAR(20)     NULL,
    [Email]                     VARCHAR(120)    NOT NULL,
    [Calle]                     VARCHAR(120)    NOT NULL, 
    [Numero]                    INT             NOT NULL, 
    [Piso]                      VARCHAR(20)     NULL, 
    [Localidad]                 VARCHAR(120)    NOT NULL, 
    [Provincia]                 VARCHAR(120)    NOT NULL, 
    [Pais]                      VARCHAR(120)    NOT NULL,
    [CoberturaMedicaId]         INT             NOT NULL,
    [CoberturaMedicaPlanId]     INT             NOT NULL,
    [NumeroAfiliado]            VARCHAR(100)    NOT NULL, 
    [FechaVencimiento]          DATETIME        NOT NULL, 
    [UsuarioModificadorId] BIGINT NOT NULL, 
    [FechaModificacion] DATETIME NOT NULL, 
    [TipoCambio] VARCHAR(100) NOT NULL,


)
