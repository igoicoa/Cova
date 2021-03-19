CREATE TABLE [dbo].[Laboratorio]
(
	[LaboratorioId]			INT             NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_LaboratorioId]	PRIMARY KEY CLUSTERED, 
    [Nombre]                VARCHAR(120)    NOT NULL, 
    [Pais]                  VARCHAR(120)    NOT NULL, 
    [Email]                 VARCHAR(120)    NULL, 
    [Telefono]              VARCHAR(100)    NULL,
)
