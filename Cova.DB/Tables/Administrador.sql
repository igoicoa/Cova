CREATE TABLE [dbo].[Administrador]
(
	[AdministradorId]		BIGINT		    NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_AdministradorId]	PRIMARY KEY CLUSTERED, 
    [Apellido]              VARCHAR(120)    NOT NULL, 
    [Nombre]                VARCHAR(120)    NOT NULL, 
    [DNI]                   INT             NOT NULL, 
    [FechaNacimiento]       DATE            NOT NULL, 
    [Sexo]                  VARCHAR(2)      NOT NULL, 
    [EstadoCivil]           VARCHAR(15)     NULL, 
    [Telefono]              VARCHAR(20)     NULL, 
    [DomicilioId]           BIGINT          NULL
        CONSTRAINT [FK_Administrador_DomicilioId]
			FOREIGN KEY REFERENCES [dbo].[Domicilio](DomicilioId)
        INDEX [idx_DomicilioId],
    [UsuarioId]             BIGINT          NOT NULL
        CONSTRAINT [FK_Administrador_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId]

)
