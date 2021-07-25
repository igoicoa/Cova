CREATE TABLE [dbo].[CentroMedico]
(
	[CentroMedicoId]	INT				NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_CentroMedicoId]	PRIMARY KEY CLUSTERED,
    [Nombre]			VARCHAR(150)	NOT NULL, 
	[Telefono]			VARCHAR(20)		NOT NULL,
	[Email]				VARCHAR(120)	NOT NULL,
    [DomicilioId]		BIGINT			NOT NULL
		CONSTRAINT [FK_CentroMedico_DomicilioId]
			FOREIGN KEY REFERENCES [dbo].[Domicilio](DomicilioId)
        INDEX [idx_DomicilioId]
)
