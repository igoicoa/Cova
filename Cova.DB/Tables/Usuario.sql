CREATE TABLE [dbo].[Usuario]
(
	[UsuarioID]		    BIGINT			    NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_UsuarioID]	PRIMARY KEY CLUSTERED,
    [Usuario]		    VARCHAR(30)		    NOT NULL,
    [Password]		    VARCHAR(250)		NOT NULL, 
    [UltimoLogin]       DATETIME            NULL, 
    [Activo]            BIT                 NOT NULL
)
