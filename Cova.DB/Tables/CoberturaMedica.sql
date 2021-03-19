CREATE TABLE [dbo].[CoberturaMedica]
(
	[CoberturaMedicaId]         INT             NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_CoberturaMedicaId]	PRIMARY KEY CLUSTERED, 
    [Nombre]                    VARCHAR(120)    NOT NULL, 
    [Plan]                      VARCHAR(100)    NOT NULL, 
    [FechaVencimiento]          DATETIME        NULL
)
