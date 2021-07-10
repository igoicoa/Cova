CREATE TABLE [dbo].[Paciente]
(
	[PacienteId]	            BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_PacienteId]	PRIMARY KEY CLUSTERED, 
    [Nombre]		            VARCHAR(120)	NOT NULL, 
    [Apellido]		            VARCHAR(120)	NOT NULL, 
    [DNI]                       INT             NOT NULL, 
    [FechaNacimiento]           DATE            NOT NULL,
    [Sexo]                      VARCHAR(2)      NOT NULL,
    [EstadoCivil]               VARCHAR(15)     NULL,
    [Telefono]                  VARCHAR(20)     NULL,
    [Email]                     VARCHAR(120)    NOT NULL,
    [DomicilioId]               BIGINT          NULL
        CONSTRAINT [FK_Paciente_DomicilioId]
			FOREIGN KEY REFERENCES [dbo].[Domicilio](DomicilioId)
        INDEX [idx_DomicilioId],
    [CoberturaMedicaPacienteId] BIGINT          NULL
        CONSTRAINT [FK_Paciente_CoberturaMedicaPacienteId]
			FOREIGN KEY REFERENCES [dbo].[CoberturaMedicaPaciente](CoberturaMedicaPacienteId)
        INDEX [idx_CoberturaMedicaId],
    [UsuarioID]                 BIGINT          NULL
        CONSTRAINT [FK_Paciente_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId]
)
