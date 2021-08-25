CREATE TABLE [dbo].[Profesional]
(
	[ProfesionalId]	    BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_ProfesionalId]	PRIMARY KEY CLUSTERED, 
    [Apellido]          VARCHAR(120)    NOT NULL, 
    [Nombre]            VARCHAR(120)    NOT NULL, 
    [DNI]               INT             NOT NULL, 
    [FechaNacimiento]   DATE            NOT NULL,
    [Sexo]              VARCHAR(2)      NOT NULL,
    [EstadoCivil]       VARCHAR(15)     NULL,
    [Telefono]          VARCHAR(20)     NULL,
    [Email]             VARCHAR(120)    NOT NULL,
    [DomicilioId]       BIGINT          NULL
        CONSTRAINT [FK_Profesional_DomicilioId]
			FOREIGN KEY REFERENCES [dbo].[Domicilio](DomicilioId)
        INDEX [idx_DomicilioId], 
    [UsuarioID] BIGINT NOT NULL
        CONSTRAINT [FK_Profesional_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId]
        
)
