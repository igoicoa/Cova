CREATE TABLE [dbo].[DigitoVerificador]
(
	[DigitoVerificadorId]		INT			    NOT NULL	    IDENTITY(1,1)
		CONSTRAINT	[PK_DigitoVerificadorId]	PRIMARY KEY CLUSTERED, 
    [Entidad]					VARCHAR(200)	NOT NULL, 
    [DVV]						BIGINT			NOT NULL
)
