CREATE TABLE [dbo].[AntecedentesPersonales]
(
	[AntecedenteId]     INT             NOT NULL    IDENTITY(1,1)
        CONSTRAINT [PK_AntecedenteId] PRIMARY KEY CLUSTERED,
    [Nombre]            VARCHAR(300)    NOT NULL
)
