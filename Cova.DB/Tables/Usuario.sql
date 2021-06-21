CREATE TABLE [dbo].[Usuario]
(
	[UsuarioID]		    BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_UsuarioID]	PRIMARY KEY CLUSTERED,
    [Usuario]		    VARCHAR(30)		NOT NULL,
    [Password]		    VARCHAR(50)		NOT NULL, 
    [UltimoLogin]       DATETIME        NULL
)
