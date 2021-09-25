CREATE TABLE [dbo].[Backups]
(
	[BackupId]          INT			    NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_BackupId]	PRIMARY KEY CLUSTERED,
    [UsuarioId]         BIGINT          NOT NULL
        CONSTRAINT [FK_Backup_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId],
    [FechaBackup]       DATETIME        NOT NULL, 
    [Archivo]           VARCHAR(500)    NOT NULL, 
    [Nombre]            VARCHAR(200)    NOT NULL
)
