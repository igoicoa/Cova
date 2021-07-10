CREATE TABLE [dbo].[CoberturaMedicaPaciente]
(
	[CoberturaMedicaPacienteId]     BIGINT              NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_CoberturaMedicaPacienteId]	PRIMARY KEY CLUSTERED, 
    [CoberturaMedicaId]             INT                 NOT NULL
        CONSTRAINT [FK_CoberturaMedicaPaciente_CoberturaMedicaId]
			FOREIGN KEY REFERENCES [dbo].[CoberturaMedica](CoberturaMedicaId), 
    [CoberturaMedicaPlanId]         INT                 NOT NULL
        CONSTRAINT [FK_CoberturaMedicaPaciente_CoberturaMedicaPlanId]
			FOREIGN KEY REFERENCES [dbo].[CoberturaMedicaPlan](PlanId),
    [NumeroAfiliado]                VARCHAR(100)        NOT NULL, 
    [FechaVencimiento]              DATETIME            NOT NULL
)
