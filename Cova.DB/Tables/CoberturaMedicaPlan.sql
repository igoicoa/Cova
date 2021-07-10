CREATE TABLE [dbo].[CoberturaMedicaPlan]
(
	[PlanId]				INT             NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_CoberturaMedicaPlanId]	PRIMARY KEY CLUSTERED, 
    [CoberturaMedicaId]		INT				NOT NULL
		CONSTRAINT [FK_CoberturaMedicaPlan_CoberturaMedicaId]
			FOREIGN KEY REFERENCES [dbo].[CoberturaMedica](CoberturaMedicaId), 
    [Nombre]				VARCHAR(100)	NOT	NULL
)
