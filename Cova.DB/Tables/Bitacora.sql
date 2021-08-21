CREATE TABLE [dbo].[Bitacora]
(
	[BitacoraId]        BIGINT			    NOT NULL	    IDENTITY(1,1)
		CONSTRAINT	[PK_BitacoraId]	PRIMARY KEY CLUSTERED, 
    [Fecha]             DATETIME            NOT NULL, 
    [UsuarioId]         BIGINT              NULL
    CONSTRAINT [FK_Bitacora_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId],
    [Criticidad]        VARCHAR(120)        NOT NULL, 
    [Mensaje]           VARCHAR(MAX)        NOT NULL, 
    [Funcionalidad]     VARCHAR(200)        NOT NULL
)
