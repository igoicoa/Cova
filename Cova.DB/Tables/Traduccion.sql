CREATE TABLE [dbo].[Traduccion]
(
	[TraduccionId] INT NOT NULL IDENTITY(1,1)
		CONSTRAINT [PK_TraduccionId] PRIMARY KEY CLUSTERED, 
    [Traduccion] VARCHAR(250) NOT NULL, 
    [IdiomaId] INT NOT NULL
        CONSTRAINT [FK_Traduccion_IdiomaId]
			FOREIGN KEY REFERENCES [dbo].[Idioma](IdiomaId), 
    [EtiquetaId] INT NOT NULL
        CONSTRAINT [FK_Traduccion_EtiquetaId]
			FOREIGN KEY REFERENCES [dbo].[Etiqueta](EtiquetaId), 
)
