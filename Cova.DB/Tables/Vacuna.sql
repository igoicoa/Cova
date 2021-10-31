CREATE TABLE [dbo].[Vacuna]
(
	[VacunaId]              INT             NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_VacunaId]	PRIMARY KEY CLUSTERED,
    [Nombre]                VARCHAR(150)    NOT NULL, 
    [Descripcion]           VARCHAR(8000)    NOT NULL, 
    [Prospecto]             VARCHAR(MAX)    NULL, 
    [Contraindicaciones]    VARCHAR(MAX)    NULL, 
    [CantidadDosis]         INT             NOT NULL, 
    [LaboratorioId]         INT             NOT NULL
        CONSTRAINT [FK_Vacuna_LaboratorioId]
			FOREIGN KEY REFERENCES [dbo].[Laboratorio](LaboratorioId)
        INDEX [idx_LaboratorioId], 
    [EdadMinimaAplicacion]  INT             NOT NULL, 
    [EdadMaximaAplicacion]  INT             NOT NULL, 
    
)
