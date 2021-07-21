CREATE TABLE [dbo].[Vacuna]
(
	[VacunaId]              INT             NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_VacunaId]	PRIMARY KEY CLUSTERED,
    [Lote]                  VARCHAR(150)    NOT NULL,
    [Nombre]                VARCHAR(150)    NOT NULL, 
    [Descripcion]           VARCHAR(250)    NOT NULL, 
    [Prospecto]             VARCHAR(MAX)    NULL, 
    [Contraindicaciones]    VARCHAR(MAX)    NULL, 
    [CantidadDosis]         INT             NOT NULL, 
    [FechaElaboracion]      DATETIME        NOT NULL, 
    [FechaVencimiento]      DATETIME        NOT NULL, 
    [Stock]                 INT             NOT NULL, 
    [LaboratorioId]         INT             NOT NULL
        CONSTRAINT [FK_Vacuna_LaboratorioId]
			FOREIGN KEY REFERENCES [dbo].[Laboratorio](LaboratorioId)
        INDEX [idx_LaboratorioId], 
    
)
