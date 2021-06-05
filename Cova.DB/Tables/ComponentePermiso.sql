CREATE TABLE [dbo].[ComponentePermiso]
(
	[IDPermiso]			INT				NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_IDPermiso]	PRIMARY KEY CLUSTERED,
	[TipoPermiso]		INT				NOT NULL,
    [FechaCreacion]		DATETIME		NOT NULL,
    [PermisoMaster]		BIT				NOT NULL,
)
